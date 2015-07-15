using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;

namespace ProWPF_C.MiscSources.WPFTutorialNet.Classes
{
    class LivePreviewComboBox : ComboBox
    {
        #region DependencyProperty LivePreviewItem

        /// <summary>
        /// Gets or sets the live preview item.
        /// </summary>
        /// <value>The live preview item.</value>
        public object LivePreviewItem
        {
            get { return GetValue(LivePreviewItemProperty); }
            set { SetValue(LivePreviewItemProperty, value); }
        }

        /// <summary>
        /// Dependency property to get or set the live preview item
        /// </summary>
        public static readonly DependencyProperty LivePreviewItemProperty =
            DependencyProperty.Register("LivePreviewItem", typeof(object), typeof(LivePreviewComboBox),
            new FrameworkPropertyMetadata(null));

        #endregion

        #region Construction

        /// <summary>
        /// Initializes a new instance of the <see cref="LivePreviewComboBox"/> class.
        /// </summary>
        public LivePreviewComboBox()
        {
            DependencyPropertyDescriptor.FromProperty(IsDropDownOpenProperty, typeof(LivePreviewComboBox))
                    .AddValueChanged(this, OnDropDownOpenChanged);
        }

        #endregion

        #region Overrides

        /// <summary>
        /// See <see cref="ComboBox.OnSelectionChanged" />
        /// </summary>
        protected override DependencyObject GetContainerForItemOverride()
        {
            var container = base.GetContainerForItemOverride();
            var comboBoxItem = container as ComboBoxItem;
            if (comboBoxItem != null)
            {
                DependencyPropertyDescriptor.FromProperty(ComboBoxItem.IsHighlightedProperty, typeof(ComboBoxItem))
                    .AddValueChanged(comboBoxItem, OnItemHighlighted);
            }
            return container;
        }

        /// <summary>
        /// See <see cref="ComboBox.OnSelectionChanged" />
        /// </summary>
        protected override void OnSelectionChanged(SelectionChangedEventArgs e)
        {
            LivePreviewItem = SelectedItem;
            base.OnSelectionChanged(e);
        }

        #endregion

        #region Private Helpers

        private void OnItemHighlighted(object sender, EventArgs e)
        {
            var comboBoxItem = sender as ComboBoxItem;
            if (comboBoxItem != null && comboBoxItem.IsHighlighted)
            {
                LivePreviewItem = comboBoxItem.DataContext;
            }
        }

        private void OnDropDownOpenChanged(object sender, EventArgs e)
        {
            if (IsDropDownOpen == false)
            {
                LivePreviewItem = SelectedItem;
            }
        }

        #endregion








    }
}
