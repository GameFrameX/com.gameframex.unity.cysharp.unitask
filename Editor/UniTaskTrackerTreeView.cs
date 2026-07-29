#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System;
using UnityEditor.IMGUI.Controls;
using Cysharp.Threading.Tasks.Internal;
using System.Text;
using System.Text.RegularExpressions;

namespace Cysharp.Threading.Tasks.Editor
{
#if UNITY_6000_0_OR_NEWER
    public class UniTaskTrackerViewItem : TreeViewItem<int>
#else
    public class UniTaskTrackerViewItem : TreeViewItem
#endif
    {
        static Regex removeHref = new Regex("<a href.+>(.+)</a>", RegexOptions.Compiled);

        public string TaskType { get; set; }
        public string Elapsed { get; set; }
        public string Status { get; set; }

        string position;
        public string Position
        {
            get { return position; }
            set
            {
                position = value;
                PositionFirstLine = GetFirstLine(position);
            }
        }

        public string PositionFirstLine { get; private set; }

        static string GetFirstLine(string str)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '\r' || str[i] == '\n')
                {
                    break;
                }
                sb.Append(str[i]);
            }

            return removeHref.Replace(sb.ToString(), "$1");
        }

        public UniTaskTrackerViewItem(int id) : base(id)
        {
        }
    }

#if UNITY_6000_0_OR_NEWER
    public class UniTaskTrackerTreeView : TreeView<int>
#else
    public class UniTaskTrackerTreeView : TreeView
#endif
    {
        const string sortedColumnIndexStateKey = "UniTaskTrackerTreeView_sortedColumnIndex";

#if UNITY_6000_0_OR_NEWER
        public IReadOnlyList<TreeViewItem<int>> CurrentBindingItems;
#else
        public IReadOnlyList<TreeViewItem> CurrentBindingItems;
#endif

        public UniTaskTrackerTreeView()
#if UNITY_6000_0_OR_NEWER
            : this(new TreeViewState<int>(), new MultiColumnHeader(new MultiColumnHeaderState(new[]
#else
            : this(new TreeViewState(), new MultiColumnHeader(new MultiColumnHeaderState(new[]
#endif
            {
                new MultiColumnHeaderState.Column() { headerContent = new GUIContent("TaskType"), width = 20},
                new MultiColumnHeaderState.Column() { headerContent = new GUIContent("Elapsed"), width = 10},
                new MultiColumnHeaderState.Column() { headerContent = new GUIContent("Status"), width = 10},
                new MultiColumnHeaderState.Column() { headerContent = new GUIContent("Position")},
            })))
        {
        }

#if UNITY_6000_0_OR_NEWER
        UniTaskTrackerTreeView(TreeViewState<int> state, MultiColumnHeader header)
#else
        UniTaskTrackerTreeView(TreeViewState state, MultiColumnHeader header)
#endif
            : base(state, header)
        {
            rowHeight = 20;
            showAlternatingRowBackgrounds = true;
            showBorder = true;
            header.sortingChanged += Header_sortingChanged;

            header.ResizeToFit();
            Reload();

            header.sortedColumnIndex = SessionState.GetInt(sortedColumnIndexStateKey, 1);
        }

        public void ReloadAndSort()
        {
            var currentSelected = this.state.selectedIDs;
            Reload();
            Header_sortingChanged(this.multiColumnHeader);
            this.state.selectedIDs = currentSelected;
        }

        private void Header_sortingChanged(MultiColumnHeader multiColumnHeader)
        {
            SessionState.SetInt(sortedColumnIndexStateKey, multiColumnHeader.sortedColumnIndex);
            var index = multiColumnHeader.sortedColumnIndex;
            var ascending = multiColumnHeader.IsSortedAscending(multiColumnHeader.sortedColumnIndex);

            var items = rootItem.children.Cast<UniTaskTrackerViewItem>();

            IOrderedEnumerable<UniTaskTrackerViewItem> orderedEnumerable;
            switch (index)
            {
                case 0:
                    orderedEnumerable = ascending ? items.OrderBy(item => item.TaskType) : items.OrderByDescending(item => item.TaskType);
                    break;
                case 1:
                    orderedEnumerable = ascending ? items.OrderBy(item => double.Parse(item.Elapsed)) : items.OrderByDescending(item => double.Parse(item.Elapsed));
                    break;
                case 2:
                    orderedEnumerable = ascending ? items.OrderBy(item => item.Status) : items.OrderByDescending(item => item.Elapsed);
                    break;
                case 3:
                    orderedEnumerable = ascending ? items.OrderBy(item => item.Position) : items.OrderByDescending(item => item.PositionFirstLine);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(index), index, null);
            }

#if UNITY_6000_0_OR_NEWER
            CurrentBindingItems = rootItem.children = orderedEnumerable.Cast<TreeViewItem<int>>().ToList();
#else
            CurrentBindingItems = rootItem.children = orderedEnumerable.Cast<TreeViewItem>().ToList();
#endif
            BuildRows(rootItem);
        }

#if UNITY_6000_0_OR_NEWER
        protected override TreeViewItem<int> BuildRoot()
        {
            var root = new TreeViewItem<int>(-1, -1);
            var children = new List<TreeViewItem<int>>();
#else
        protected override TreeViewItem BuildRoot()
        {
            var root = new TreeViewItem { depth = -1 };
            var children = new List<TreeViewItem>();
#endif

            TaskTracker.ForEachActiveTask((trackingId, awaiterType, status, created, stackTrace) =>
            {
                children.Add(new UniTaskTrackerViewItem(trackingId) { TaskType = awaiterType, Status = status.ToString(), Elapsed = (DateTime.UtcNow - created).TotalSeconds.ToString("00.00"), Position = stackTrace });
            });

            CurrentBindingItems = children;
#if UNITY_6000_0_OR_NEWER
            root.children = CurrentBindingItems as List<TreeViewItem<int>>;
#else
            root.children = CurrentBindingItems as List<TreeViewItem>;
#endif
            return root;
        }

#if UNITY_6000_0_OR_NEWER
        protected override bool CanMultiSelect(TreeViewItem<int> item)
#else
        protected override bool CanMultiSelect(TreeViewItem item)
#endif
        {
            return false;
        }

        protected override void RowGUI(RowGUIArgs args)
        {
            var item = args.item as UniTaskTrackerViewItem;

            for (var visibleColumnIndex = 0; visibleColumnIndex < args.GetNumVisibleColumns(); visibleColumnIndex++)
            {
                var rect = args.GetCellRect(visibleColumnIndex);
                var columnIndex = args.GetColumn(visibleColumnIndex);

                var labelStyle = args.selected ? EditorStyles.whiteLabel : EditorStyles.label;
                labelStyle.alignment = TextAnchor.MiddleLeft;
                switch (columnIndex)
                {
                    case 0:
                        EditorGUI.LabelField(rect, item.TaskType, labelStyle);
                        break;
                    case 1:
                        EditorGUI.LabelField(rect, item.Elapsed, labelStyle);
                        break;
                    case 2:
                        EditorGUI.LabelField(rect, item.Status, labelStyle);
                        break;
                    case 3:
                        EditorGUI.LabelField(rect, item.PositionFirstLine, labelStyle);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(columnIndex), columnIndex, null);
                }
            }
        }
    }
}
