using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Garment
{
    public partial class Item :UserControl
    {
        public Item()
        {
            InitializeComponent();
            DisableCategory1checkedListBox();
            DisableCategory2checkedListBox();
            UncheckedCategory1checkedLisBox();
            UncheckedCategory2_checkedLisBox();
            MencheckedListBox.BringToFront();
            Men_pakistani_checkedListBox.BringToFront();
            Category1lbl.Enabled = false;
            Category2lbl.Enabled = false;

        }

        static int record = 0;
        bool hide = false;

        private void ItemChoiceSlidderbtn_Click_1(object sender, EventArgs e)
        {
            ItemChoiceSlidderbtn.BringToFront();

            if (hide)
            {
                ItemChoicepanel.Visible = true;
                //Itempanel.BringToFront();
                hide = false;
                Itempanel.Location = new Point(247, 0);
                generateListpanel.Location = new Point(247, 0);
                viewListpanel.Location = new Point(247, 0);
            }
            else
            {
                ItemChoicepanel.Visible = false;
                hide = true;
                Itempanel.Location = new Point(12, 0);
                generateListpanel.Location = new Point(12, 0);
                viewListpanel.Location = new Point(12, 0);
            }
            
        }

        private void Item_Seaarchbtn_Click(object sender, EventArgs e)
        {
            int searched = 0;
            for (int j = 0; j < ProductUC.itemList.Count; j++)
            {
                if (ProductUC.itemList[j].barcode.ToUpper() == Item_Seaarchtxt.Text.ToUpper())
                {
                    ItemsListView.Items.Clear();
                    ListViewItem itemListView = new ListViewItem();
                    ItemsListView.SmallImageList = ProductUC.images;
                    itemListView.ImageIndex = j;
                    itemListView.SubItems.Add(ProductUC.itemList[j].name);
                    itemListView.SubItems.Add(ProductUC.itemList[j].barcode);
                    itemListView.SubItems.Add("RS" + ProductUC.itemList[j].price.ToString());
                    itemListView.SubItems.Add(ProductUC.itemList[j].quantity.ToString());
                    itemListView.SubItems.Add(ProductUC.itemList[j].color);
                    itemListView.SubItems.Add(ProductUC.itemList[j].material);

                    ItemsListView.Items.Add(itemListView);
                    record = 1;
                    ItemRecordlbl.Text = "Total record = " + record;
                    searched = 58;

                    break;
                }
            }
            if (searched != 58)
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void Item_Seaarchtxt_clearbtn_Click(object sender, EventArgs e)
        {
            Item_Seaarchtxt.Clear();
            Item_Seaarchtxt_clearbtn.Visible = false;
        }

        private void Item_Seaarchtxt_TextChanged(object sender, EventArgs e)
        {
            if (Item_Seaarchtxt.Text == "")
                Item_Seaarchtxt_clearbtn.Visible = false;
            else
                Item_Seaarchtxt_clearbtn.Visible = true;
        }

        private void Item_Refreshhbtn_Click(object sender, EventArgs e)
        {
            ItemRefresh();
        }
        double min = 0, max = 0;
        static int k=0;
        private void ItemPricetrackBar_Scroll(object sender, EventArgs e)
        {++k;
            if(k==1)
            {
            for (int i = 0; i < ProductUC.itemList.Count; ++i)
            {
                foreach (ListViewItem item in ItemsListView.Items)
                {
                    if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                    {
                        //if (min > ProductUC.itemList[i].price)
                        //{
                        //    min = ProductUC.itemList[i].price;
                        //}
                        if (max < ProductUC.itemList[i].price)
                        {
                            max = ProductUC.itemList[i].price;
                        }

                    }
                }
            }
            }
            ItemPricetrackBar.Minimum = 0;
            if (ItemsListView.Items.Count > 0)
            {

                ItemRSstartlbl.Text = "RS " + ItemPricetrackBar.Value.ToString();
                ItemRSendlbl.Text = "RS " + max;
            }
            else
                ItemRSstartlbl.Text = "RS ----";

        }

        private void ItemPricetrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (ItemsListView.Items.Count > 0)
            {
                for (int i = 0; i < ProductUC.itemList.Count; ++i)
                {
                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            //if (min > ProductUC.itemList[i].price)
                            //{
                            //    min = ProductUC.itemList[i].price;
                            //}
                            if (max < ProductUC.itemList[i].price)
                            {
                                max = ProductUC.itemList[i].price;
                            }

                        }

                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].price < ItemPricetrackBar.Value)
                            {
                                item.Remove();
                                --record;
                            }
                        }
                    }
                }


                ItemPricetrackBar.Maximum = Convert.ToInt32(max);
                min = ItemPricetrackBar.Value;
                ItemPricetrackBar.Minimum = 0;
                //ItemPricetrackBar.Maximum = Convert.ToInt32(max);
                ItemRecordlbl.Text = "Total record = " + record;
                //ItemRSstartlbl.Visible = false;
            }
        }

        void DisableCategory1checkedListBox()
        {
            MencheckedListBox.Enabled = false;
            WomencheckedListBox.Enabled = false;
            KidscheckedListBox.Enabled = false;
        }

        #region DisableCategory2checkedListBox()
        void DisableCategory2_MencheckedListBox()
        {
            Men_pakistani_checkedListBox.Enabled = false;
            Men_western_checkedListBox.Enabled = false;
            Men_winter_checkedListBox.Enabled = false;
            Men_watches_checkedListBox.Enabled = false;
            Men_shoes_checkedListBox.Enabled = false;
            Men_accessories_checkedListBox.Enabled = false;
        }

        void DisableCategory2_WomencheckedListBox()
        {
            Women_pakistani_checkedListBox.Enabled = false;
            Women_western_checkedListBox.Enabled = false;
            Women_winter_checkedListBox.Enabled = false;
            Women_watches_checkedListBox.Enabled = false;
            Women_shoes_checkedListBox.Enabled = false;
            Women_accessories_checkedListBox.Enabled = false;
        }

        void DisableCategory2_KidscheckedListBox()
        {

            Kids_BabycheckedListBox.Enabled = false;
            Kids_BoycheckedListBox.Enabled = false;
            Kids_GirlcheckedListBox.Enabled = false;

        }

        void DisableCategory2checkedListBox()
        {
            DisableCategory2_MencheckedListBox();
            DisableCategory2_WomencheckedListBox();
            DisableCategory2_KidscheckedListBox();

        }
        #endregion

        void UncheckedCategorycheckedLisBox()
        {
            CategorycheckedListBox.SetItemChecked(0, false);
            CategorycheckedListBox.SetItemChecked(1, false);
            CategorycheckedListBox.SetItemChecked(2, false);
            CategorycheckedListBox.SetItemChecked(3, false);
        }

        void UnselectedCategorycheckedLisBox()
        {
            CategorycheckedListBox.SetSelected(0, false);
            CategorycheckedListBox.SetSelected(1, false);
            CategorycheckedListBox.SetSelected(2, false);
            CategorycheckedListBox.SetSelected(3, false);
        }

        #region UnselectedCategory1checkedLisBox()
        void UnselectedCategory1_MencheckedLisBox()
        {
            MencheckedListBox.SetSelected(0, false);
            MencheckedListBox.SetSelected(1, false);
            MencheckedListBox.SetSelected(2, false);
            MencheckedListBox.SetSelected(3, false);
            MencheckedListBox.SetSelected(4, false);
            MencheckedListBox.SetSelected(5, false);
        }

        void UnselectedCategory1_WomencheckedLisBox()
        {
            WomencheckedListBox.SetSelected(0, false);
            WomencheckedListBox.SetSelected(1, false);
            WomencheckedListBox.SetSelected(2, false);
            WomencheckedListBox.SetSelected(3, false);
            WomencheckedListBox.SetSelected(4, false);
            WomencheckedListBox.SetSelected(5, false);
        }

        void UnselectedCategory1_KidscheckedLisBox()
        {
            KidscheckedListBox.SetSelected(0, false);
            KidscheckedListBox.SetSelected(1, false);
            KidscheckedListBox.SetSelected(2, false);
        }

        void UnselectedCategory1checkedLisBox()
        {
            UnselectedCategory1_MencheckedLisBox();
            UnselectedCategory1_WomencheckedLisBox();
            UnselectedCategory1_KidscheckedLisBox();
        }
        #endregion

        #region UncheckedCategory1checkedLisBox()
        void UncheckedCategory1_MencheckedLisBox()
        {
            MencheckedListBox.SetItemCheckState(0, CheckState.Unchecked);
            MencheckedListBox.SetItemCheckState(1, CheckState.Unchecked);
            MencheckedListBox.SetItemCheckState(2, CheckState.Unchecked);
            MencheckedListBox.SetItemCheckState(3, CheckState.Unchecked);
            MencheckedListBox.SetItemCheckState(4, CheckState.Unchecked);
            MencheckedListBox.SetItemCheckState(5, CheckState.Unchecked);
        }

        void UncheckedCategory1_WomencheckedLisBox()
        {
            WomencheckedListBox.SetItemCheckState(0, CheckState.Unchecked);
            WomencheckedListBox.SetItemCheckState(1, CheckState.Unchecked);
            WomencheckedListBox.SetItemCheckState(2, CheckState.Unchecked);
            WomencheckedListBox.SetItemCheckState(3, CheckState.Unchecked);
            WomencheckedListBox.SetItemCheckState(4, CheckState.Unchecked);
            WomencheckedListBox.SetItemCheckState(5, CheckState.Unchecked);
        }

        void UncheckedCategory1_KidscheckedLisBox()
        {
            KidscheckedListBox.SetItemCheckState(0, CheckState.Unchecked);
            KidscheckedListBox.SetItemCheckState(1, CheckState.Unchecked);
            KidscheckedListBox.SetItemCheckState(2, CheckState.Unchecked);
        }

        void UncheckedCategory1checkedLisBox()
        {
            UncheckedCategory1_MencheckedLisBox();
            UncheckedCategory1_WomencheckedLisBox();
            UncheckedCategory1_KidscheckedLisBox();
        }
        #endregion

        #region UnselectedCategory2_checkedLisBox
        #region UnselectedCategory2_MencheckedLisBox()
        void UnselectedCategory2_Men_pakistanicheckedLisBox()
        {
            Men_pakistani_checkedListBox.SetSelected(0, false);
            Men_pakistani_checkedListBox.SetSelected(1, false);
            Men_pakistani_checkedListBox.SetSelected(2, false);
            Men_pakistani_checkedListBox.SetSelected(3, false);
        }
        void UnselectedCategory2_Men_westerncheckedLisBox()
        {
            Men_western_checkedListBox.SetSelected(0, false);
            Men_western_checkedListBox.SetSelected(1, false);
            Men_western_checkedListBox.SetSelected(2, false);
            Men_western_checkedListBox.SetSelected(3, false);
            Men_western_checkedListBox.SetSelected(4, false);
            Men_western_checkedListBox.SetSelected(5, false);
        }
        void UnselectedCategory2_Men_wintercheckedLisBox()
        {
            Men_winter_checkedListBox.SetSelected(0, false);
            Men_winter_checkedListBox.SetSelected(1, false);
            Men_winter_checkedListBox.SetSelected(2, false);
        }
        void UnselectedCategory2_Men_shoescheckedLisBox()
        {
            Men_shoes_checkedListBox.SetSelected(0, false);
            Men_shoes_checkedListBox.SetSelected(1, false);
            Men_shoes_checkedListBox.SetSelected(2, false);
            Men_shoes_checkedListBox.SetSelected(3, false);
            Men_shoes_checkedListBox.SetSelected(4, false);
        }
        void UnselectedCategory2_Men_watchescheckedLisBox()
        {
            Men_watches_checkedListBox.SetSelected(0, false);
            Men_watches_checkedListBox.SetSelected(1, false);
            Men_watches_checkedListBox.SetSelected(2, false);
            Men_watches_checkedListBox.SetSelected(3, false);
        }
        void UnselectedCategory2_Men_accessoriescheckedLisBox()
        {
            Men_accessories_checkedListBox.SetSelected(0, false);
            Men_accessories_checkedListBox.SetSelected(1, false);
            Men_accessories_checkedListBox.SetSelected(2, false);
            Men_accessories_checkedListBox.SetSelected(3, false);
            Men_accessories_checkedListBox.SetSelected(4, false);
            Men_accessories_checkedListBox.SetSelected(5, false);
        }

        void UnselectedCategory2_MencheckedLisBox()
        {
            UnselectedCategory2_Men_pakistanicheckedLisBox();
            UnselectedCategory2_Men_shoescheckedLisBox();
            UnselectedCategory2_Men_watchescheckedLisBox();
            UnselectedCategory2_Men_westerncheckedLisBox();
            UnselectedCategory2_Men_wintercheckedLisBox();
            UnselectedCategory2_Men_accessoriescheckedLisBox();
        }
        #endregion

        #region UnselectedCategory2_WomencheckedLisBox
        void UnselectedCategory2_Women_pakistanicheckedLisBox()
        {
            Women_pakistani_checkedListBox.SetSelected(0, false);
            Women_pakistani_checkedListBox.SetSelected(1, false);
            Women_pakistani_checkedListBox.SetSelected(2, false);
            Women_pakistani_checkedListBox.SetSelected(3, false);
            Women_pakistani_checkedListBox.SetSelected(4, false);
        }
        void UnselectedCategory2_Women_westerncheckedLisBox()
        {
            Women_western_checkedListBox.SetSelected(0, false);
            Women_western_checkedListBox.SetSelected(1, false);
            Women_western_checkedListBox.SetSelected(2, false);
            Women_western_checkedListBox.SetSelected(3, false);
        }
        void UnselectedCategory2_Women_wintercheckedLisBox()
        {
            Women_winter_checkedListBox.SetSelected(0, false);
            Women_winter_checkedListBox.SetSelected(1, false);
        }
        void UnselectedCategory2_Women_shoescheckedLisBox()
        {
            Women_shoes_checkedListBox.SetSelected(0, false);
            Women_shoes_checkedListBox.SetSelected(1, false);
            Women_shoes_checkedListBox.SetSelected(2, false);
            Women_shoes_checkedListBox.SetSelected(3, false);
            Women_shoes_checkedListBox.SetSelected(4, false);
            Women_shoes_checkedListBox.SetSelected(5, false);
        }
        void UnselectedCategory2_Women_watchescheckedLisBox()
        {
            Women_watches_checkedListBox.SetSelected(0, false);
            Women_watches_checkedListBox.SetSelected(1, false);
            Women_watches_checkedListBox.SetSelected(2, false);
            Women_watches_checkedListBox.SetSelected(3, false);
        }
        void UnselectedCategory2_Women_accessoriescheckedLisBox()
        {
            Women_accessories_checkedListBox.SetSelected(0, false);
            Women_accessories_checkedListBox.SetSelected(1, false);
            Women_accessories_checkedListBox.SetSelected(2, false);
            Women_accessories_checkedListBox.SetSelected(3, false);
        }

        void UnselectedCategory2_WomencheckedLisBox()
        {
            UnselectedCategory2_Women_accessoriescheckedLisBox();
            UnselectedCategory2_Women_pakistanicheckedLisBox();
            UnselectedCategory2_Women_shoescheckedLisBox();
            UnselectedCategory2_Women_watchescheckedLisBox();
            UnselectedCategory2_Women_westerncheckedLisBox();
            UnselectedCategory2_Women_wintercheckedLisBox();
        }
        #endregion

        #region UnselectedCategory2_KidscheckedLisBox
        void UnselectedCategory2_Kids_BabycheckedLisBox()
        {
            Kids_BabycheckedListBox.SetSelected(0, false);
            Kids_BabycheckedListBox.SetSelected(1, false);
            Kids_BabycheckedListBox.SetSelected(2, false);
        }
        void UnselectedCategory2_Kids_BoycheckedLisBox()
        {
            Kids_BoycheckedListBox.SetSelected(0, false);
            Kids_BoycheckedListBox.SetSelected(1, false);
            Kids_BoycheckedListBox.SetSelected(2, false);
        }
        void UnselectedCategory2_Kids_GirlcheckedLisBox()
        {
            Kids_GirlcheckedListBox.SetSelected(0, false);
            Kids_GirlcheckedListBox.SetSelected(1, false);
            Kids_GirlcheckedListBox.SetSelected(2, false);
        }

        void UnselectedCategory2_KidscheckedLisBox()
        {
            UnselectedCategory2_Kids_BabycheckedLisBox();
            UnselectedCategory2_Kids_BoycheckedLisBox();
            UnselectedCategory2_Kids_GirlcheckedLisBox();
        }
        #endregion


        void UnselectedCategory2_checkedLisBox()
        {
            UnselectedCategory2_MencheckedLisBox();
            UnselectedCategory2_WomencheckedLisBox();
            UnselectedCategory2_KidscheckedLisBox();
        }
        #endregion

        #region UncheckedCategory2_checkedLisBox
        #region UncheckedCategory2_MencheckedLisBox()
        void UncheckedCategory2_Men_pakistanicheckedLisBox()
        {
            Men_pakistani_checkedListBox.SetItemCheckState(0, CheckState.Unchecked);
            Men_pakistani_checkedListBox.SetItemCheckState(1, CheckState.Unchecked);
            Men_pakistani_checkedListBox.SetItemCheckState(2, CheckState.Unchecked);
            Men_pakistani_checkedListBox.SetItemCheckState(3, CheckState.Unchecked);
        }
        void UncheckedCategory2_Men_westerncheckedLisBox()
        {
            Men_western_checkedListBox.SetItemCheckState(0, CheckState.Unchecked);
            Men_western_checkedListBox.SetItemCheckState(1, CheckState.Unchecked);
            Men_western_checkedListBox.SetItemCheckState(2, CheckState.Unchecked);
            Men_western_checkedListBox.SetItemCheckState(3, CheckState.Unchecked);
            Men_western_checkedListBox.SetItemCheckState(4, CheckState.Unchecked);
            Men_western_checkedListBox.SetItemCheckState(5, CheckState.Unchecked);
        }
        void UncheckedCategory2_Men_wintercheckedLisBox()
        {
            Men_winter_checkedListBox.SetItemCheckState(0, CheckState.Unchecked);
            Men_winter_checkedListBox.SetItemCheckState(1, CheckState.Unchecked);
            Men_winter_checkedListBox.SetItemCheckState(2, CheckState.Unchecked);
        }
        void UncheckedCategory2_Men_shoescheckedLisBox()
        {
            Men_shoes_checkedListBox.SetItemCheckState(0, CheckState.Unchecked);
            Men_shoes_checkedListBox.SetItemCheckState(1, CheckState.Unchecked);
            Men_shoes_checkedListBox.SetItemCheckState(2, CheckState.Unchecked);
            Men_shoes_checkedListBox.SetItemCheckState(3, CheckState.Unchecked);
            Men_shoes_checkedListBox.SetItemCheckState(4, CheckState.Unchecked);
        }
        void UncheckedCategory2_Men_watchescheckedLisBox()
        {
            Men_watches_checkedListBox.SetItemCheckState(0, CheckState.Unchecked);
            Men_watches_checkedListBox.SetItemCheckState(1, CheckState.Unchecked);
            Men_watches_checkedListBox.SetItemCheckState(2, CheckState.Unchecked);
            Men_watches_checkedListBox.SetItemCheckState(3, CheckState.Unchecked);
        }
        void UncheckedCategory2_Men_accessoriescheckedLisBox()
        {
            Men_accessories_checkedListBox.SetItemCheckState(0, CheckState.Unchecked);
            Men_accessories_checkedListBox.SetItemCheckState(1, CheckState.Unchecked);
            Men_accessories_checkedListBox.SetItemCheckState(2, CheckState.Unchecked);
            Men_accessories_checkedListBox.SetItemCheckState(3, CheckState.Unchecked);
            Men_accessories_checkedListBox.SetItemCheckState(4, CheckState.Unchecked);
            Men_accessories_checkedListBox.SetItemCheckState(5, CheckState.Unchecked);
        }

        void UncheckedCategory2_MencheckedLisBox()
        {
            UncheckedCategory2_Men_pakistanicheckedLisBox();
            UnselectedCategory2_Men_shoescheckedLisBox();
            UncheckedCategory2_Men_watchescheckedLisBox();
            UncheckedCategory2_Men_westerncheckedLisBox();
            UncheckedCategory2_Men_wintercheckedLisBox();
            UncheckedCategory2_Men_accessoriescheckedLisBox();
        }
        #endregion

        #region UncheckedCategory2_WomencheckedLisBox
        void UncheckedCategory2_Women_pakistanicheckedLisBox()
        {
            Women_pakistani_checkedListBox.SetItemCheckState(0, CheckState.Unchecked);
            Women_pakistani_checkedListBox.SetItemCheckState(1, CheckState.Unchecked);
            Women_pakistani_checkedListBox.SetItemCheckState(2, CheckState.Unchecked);
            Women_pakistani_checkedListBox.SetItemCheckState(3, CheckState.Unchecked);
            Women_pakistani_checkedListBox.SetItemCheckState(4, CheckState.Unchecked);
        }
        void UncheckedCategory2_Women_westerncheckedLisBox()
        {
            Women_western_checkedListBox.SetItemCheckState(0, CheckState.Unchecked);
            Women_western_checkedListBox.SetItemCheckState(1, CheckState.Unchecked);
            Women_western_checkedListBox.SetItemCheckState(2, CheckState.Unchecked);
            Women_western_checkedListBox.SetItemCheckState(3, CheckState.Unchecked);
        }
        void UncheckedCategory2_Women_wintercheckedLisBox()
        {
            Women_winter_checkedListBox.SetItemCheckState(0, CheckState.Unchecked);
            Women_winter_checkedListBox.SetItemCheckState(1, CheckState.Unchecked);
        }
        void UncheckedCategory2_Women_shoescheckedLisBox()
        {
            Women_shoes_checkedListBox.SetItemCheckState(0, CheckState.Unchecked);
            Women_shoes_checkedListBox.SetItemCheckState(1, CheckState.Unchecked);
            Women_shoes_checkedListBox.SetItemCheckState(2, CheckState.Unchecked);
            Women_shoes_checkedListBox.SetItemCheckState(3, CheckState.Unchecked);
            Women_shoes_checkedListBox.SetItemCheckState(4, CheckState.Unchecked);
            Women_shoes_checkedListBox.SetItemCheckState(5, CheckState.Unchecked);
        }
        void UncheckedCategory2_Women_watchescheckedLisBox()
        {
            Women_watches_checkedListBox.SetItemCheckState(0, CheckState.Unchecked);
            Women_watches_checkedListBox.SetItemCheckState(1, CheckState.Unchecked);
            Women_watches_checkedListBox.SetItemCheckState(2, CheckState.Unchecked);
            Women_watches_checkedListBox.SetItemCheckState(3, CheckState.Unchecked);
        }
        void UncheckedCategory2_Women_accessoriescheckedLisBox()
        {
            Women_accessories_checkedListBox.SetItemCheckState(0, CheckState.Unchecked);
            Women_accessories_checkedListBox.SetItemCheckState(1, CheckState.Unchecked);
            Women_accessories_checkedListBox.SetItemCheckState(2, CheckState.Unchecked);
            Women_accessories_checkedListBox.SetItemCheckState(3, CheckState.Unchecked);
        }

        void UncheckedCategory2_WomencheckedLisBox()
        {
            UncheckedCategory2_Women_accessoriescheckedLisBox();
            UncheckedCategory2_Women_pakistanicheckedLisBox();
            UncheckedCategory2_Women_shoescheckedLisBox();
            UncheckedCategory2_Women_watchescheckedLisBox();
            UncheckedCategory2_Women_westerncheckedLisBox();
            UncheckedCategory2_Women_wintercheckedLisBox();
        }
        #endregion

        #region UncheckedCategory2_KidscheckedLisBox
        void UncheckedCategory2_Kids_BabycheckedLisBox()
        {
            Kids_BabycheckedListBox.SetItemCheckState(0, CheckState.Unchecked);
            Kids_BabycheckedListBox.SetItemCheckState(1, CheckState.Unchecked);
            Kids_BabycheckedListBox.SetItemCheckState(2, CheckState.Unchecked);
        }
        void UncheckedCategory2_Kids_BoycheckedLisBox()
        {
            Kids_BoycheckedListBox.SetItemCheckState(0, CheckState.Unchecked);
            Kids_BoycheckedListBox.SetItemCheckState(1, CheckState.Unchecked);
            Kids_BoycheckedListBox.SetItemCheckState(2, CheckState.Unchecked);
        }
        void UncheckedCategory2_Kids_GirlcheckedLisBox()
        {
            Kids_GirlcheckedListBox.SetItemCheckState(0, CheckState.Unchecked);
            Kids_GirlcheckedListBox.SetItemCheckState(1, CheckState.Unchecked);
            Kids_GirlcheckedListBox.SetItemCheckState(2, CheckState.Unchecked);
        }

        void UncheckedCategory2_KidscheckedLisBox()
        {
            UncheckedCategory2_Kids_BabycheckedLisBox();
            UncheckedCategory2_Kids_BoycheckedLisBox();
            UncheckedCategory2_Kids_GirlcheckedLisBox();
        }
        #endregion

        void UncheckedCategory2_checkedLisBox()
        {
            UncheckedCategory2_MencheckedLisBox();
            UncheckedCategory2_WomencheckedLisBox();
            UncheckedCategory2_KidscheckedLisBox();
        }
        #endregion

        void UnselectedColorcheckedListBox()
        {
            ColorcheckedListBox.SetSelected(0, false);
            ColorcheckedListBox.SetSelected(1, false);
            ColorcheckedListBox.SetSelected(2, false);
            ColorcheckedListBox.SetSelected(3, false);
            ColorcheckedListBox.SetSelected(4, false);
            ColorcheckedListBox.SetSelected(5, false);
            ColorcheckedListBox.SetSelected(6, false);
            ColorcheckedListBox.SetSelected(7, false);
            ColorcheckedListBox.SetSelected(8, false);
            ColorcheckedListBox.SetSelected(9, false);
            ColorcheckedListBox.SetSelected(10, false);
            ColorcheckedListBox.SetSelected(11, false);
            ColorcheckedListBox.SetSelected(12, false);
            ColorcheckedListBox.SetSelected(13, false);
        }

        void UncheckedColorcheckedListBox()
        {
            ColorcheckedListBox.SetItemChecked(0, false);
            ColorcheckedListBox.SetItemChecked(1, false);
            ColorcheckedListBox.SetItemChecked(2, false);
            ColorcheckedListBox.SetItemChecked(3, false);
            ColorcheckedListBox.SetItemChecked(4, false);
            ColorcheckedListBox.SetItemChecked(5, false);
            ColorcheckedListBox.SetItemChecked(6, false);
            ColorcheckedListBox.SetItemChecked(7, false);
            ColorcheckedListBox.SetItemChecked(8, false);
            ColorcheckedListBox.SetItemChecked(9, false);
            ColorcheckedListBox.SetItemChecked(10, false);
            ColorcheckedListBox.SetItemChecked(11, false);
            ColorcheckedListBox.SetItemChecked(12, false);
            ColorcheckedListBox.SetItemChecked(13, false);
        }

        void UnselectedClothingcheckedListBox()
        {
            ClothingcheckedListBox.SetSelected(0, false);
            ClothingcheckedListBox.SetSelected(1, false);
            ClothingcheckedListBox.SetSelected(2, false);
            ClothingcheckedListBox.SetSelected(3, false);
            ClothingcheckedListBox.SetSelected(4, false);
            ClothingcheckedListBox.SetSelected(5, false);
            ClothingcheckedListBox.SetSelected(6, false);
            ClothingcheckedListBox.SetSelected(7, false);
            ClothingcheckedListBox.SetSelected(8, false);
        }

        void UncheckedClothingcheckedListBox()
        {
            ClothingcheckedListBox.SetItemChecked(0, false);
            ClothingcheckedListBox.SetItemChecked(1, false);
            ClothingcheckedListBox.SetItemChecked(2, false);
            ClothingcheckedListBox.SetItemChecked(3, false);
            ClothingcheckedListBox.SetItemChecked(4, false);
            ClothingcheckedListBox.SetItemChecked(5, false);
            ClothingcheckedListBox.SetItemChecked(6, false);
            ClothingcheckedListBox.SetItemChecked(7, false);
            ClothingcheckedListBox.SetItemChecked(8, false);
        }

        void UnselectedMaterialcheckedListBox()
        {
            MaterialcheckedListBox.SetSelected(0, false);
            MaterialcheckedListBox.SetSelected(1, false);
            MaterialcheckedListBox.SetSelected(2, false);
            MaterialcheckedListBox.SetSelected(3, false);
            MaterialcheckedListBox.SetSelected(4, false);
            MaterialcheckedListBox.SetSelected(5, false);
            MaterialcheckedListBox.SetSelected(6, false);
            MaterialcheckedListBox.SetSelected(7, false);
            MaterialcheckedListBox.SetSelected(8, false);
            MaterialcheckedListBox.SetSelected(9, false);
            MaterialcheckedListBox.SetSelected(10, false);
        }

        void UncheckedMaterialcheckedListBox()
        {
            MaterialcheckedListBox.SetItemChecked(0, false);
            MaterialcheckedListBox.SetItemChecked(1, false);
            MaterialcheckedListBox.SetItemChecked(2, false);
            MaterialcheckedListBox.SetItemChecked(3, false);
            MaterialcheckedListBox.SetItemChecked(4, false);
            MaterialcheckedListBox.SetItemChecked(5, false);
            MaterialcheckedListBox.SetItemChecked(6, false);
            MaterialcheckedListBox.SetItemChecked(7, false);
            MaterialcheckedListBox.SetItemChecked(8, false);
            MaterialcheckedListBox.SetItemChecked(9, false);
            MaterialcheckedListBox.SetItemChecked(10, false);
        }

        void DataEntry()
        {
            ProductUC ProductUC = new ProductUC();
            var paths = Directory.GetFiles("D:\\Pics").OrderBy(f => f.Length);
            ProductUC.images.ImageSize = new Size(150, 150);

            foreach (var path in paths)
            {
                ProductUC.images.Images.Add(Image.FromFile(path.ToString()));
                //MessageBox.Show(path.ToString());
            }
            //ProductUC.Data();
        }

        void AddAllItems()
        {
            int check = 0;
            for (int i = 0; i < ProductUC.itemList.Count; i++)
            {
                check = 0;
                foreach (ListViewItem item in ItemsListView.Items)
                {
                    if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                    {
                        ++check;
                    }
                }
                if (check == 0)
                {
                    ListViewItem itemListView = new ListViewItem();
                    ItemsListView.SmallImageList = ProductUC.images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(ProductUC.itemList[i].name);
                    itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                    itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(ProductUC.itemList[i].color);
                    itemListView.SubItems.Add(ProductUC.itemList[i].material);

                    ItemsListView.Items.Add(itemListView);
                    ++record;
                }
            }
        }

        void ItemRefresh()
        {
            UncheckedCategorycheckedLisBox();
            UncheckedCategory1checkedLisBox();
            UncheckedCategory2_checkedLisBox();
            UncheckedColorcheckedListBox();
            UncheckedClothingcheckedListBox();
            UncheckedMaterialcheckedListBox();

            UnselectedCategorycheckedLisBox();
            UnselectedCategory1checkedLisBox();
            UnselectedCategory2_checkedLisBox();
            UnselectedColorcheckedListBox();
            UnselectedClothingcheckedListBox();
            UnselectedMaterialcheckedListBox();
            CategorycheckedListBox.SetItemChecked(3, true);
            Item_Seaarchtxt.Clear();

            AddAllItems();
            ItemRecordlbl.Text = "Total record = " + record;
        }

        private void Item_Load(object sender, EventArgs e)
        {
            ItemRefresh();
            //ItemListView_columnWidthSet_NotHide();
            Itempanel.BringToFront();
        }

        private void CategorycheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check = 0;
            int secret = 0;
            int secret1 = 0;
            for (int i = 0; i < CategorycheckedListBox.Items.Count; ++i)
            {
                if (CategorycheckedListBox.GetSelected(i))
                {
                    secret = i;
                    secret1 = i;
                    break;
                }
            }

            if (CategorycheckedListBox.GetItemChecked(0) == true && secret == 0)
            {
                DisableCategory1checkedListBox();
                MencheckedListBox.Enabled = true;
                MencheckedListBox.BringToFront();
                Category1lbl.Enabled = true;
                Category1lbl.Text = "Men Clothing";
                UncheckedCategorycheckedLisBox();
                CategorycheckedListBox.SetItemChecked(0, true);

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Men")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category != "Men")
                            {
                                item.Remove();
                                --record;
                            }

                        }
                    }
                }


                ItemRecordlbl.Text = "Total record = " + record;

                return;
            }

            else
            {
                if (secret1 == 0)
                {
                    MencheckedListBox.Enabled = false;
                    DisableCategory2_MencheckedListBox();
                    Category1lbl.Enabled = false;
                    Category1lbl.Text = "Category 1";
                    Category2lbl.Enabled = false;
                    Category2lbl.Text = "Category2";
                    UncheckedCategory1_MencheckedLisBox();
                    UncheckedCategory2_MencheckedLisBox();

                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men")
                                    item.Remove();
                                --record;
                            }

                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

            if (CategorycheckedListBox.GetItemChecked(1) == true && secret == 1)
            {
                DisableCategory2checkedListBox();
                Category1lbl.Enabled = true;
                Category1lbl.Text = "Women Clothing";
                WomencheckedListBox.Enabled = true;
                UncheckedCategorycheckedLisBox();
                CategorycheckedListBox.SetItemChecked(1, true);
                WomencheckedListBox.BringToFront();

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category != "Women")
                            {
                                item.Remove();
                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;

            }
            else
            {
                if (secret1 == 1)
                {
                    WomencheckedListBox.Enabled = false;
                    DisableCategory2_WomencheckedListBox();
                    Category1lbl.Enabled = false;
                    Category1lbl.Text = "Category1";
                    Category2lbl.Enabled = false;
                    Category2lbl.Text = "Category2";
                    UncheckedCategory1_WomencheckedLisBox();
                    UncheckedCategory2_WomencheckedLisBox();
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women")
                                    item.Remove();
                                --record;
                            }

                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

            if (CategorycheckedListBox.GetItemChecked(2) == true && secret == 2)
            {
                DisableCategory2checkedListBox();
                Category1lbl.Enabled = true;
                Category1lbl.Text = "Kids Clothing";
                KidscheckedListBox.Enabled = true;
                UncheckedCategorycheckedLisBox();
                CategorycheckedListBox.SetItemChecked(2, true);
                KidscheckedListBox.BringToFront();

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Kids")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category != "Kids")
                            {
                                item.Remove();
                                --record;
                            }

                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 2)
                {
                    KidscheckedListBox.Enabled = false;
                    DisableCategory2_KidscheckedListBox();
                    Category1lbl.Enabled = false;
                    Category1lbl.Text = "Category1";
                    Category2lbl.Enabled = false;
                    Category2lbl.Text = "Category2";
                    UncheckedCategory1_KidscheckedLisBox();
                    UncheckedCategory1_KidscheckedLisBox();
                    UncheckedCategory2_KidscheckedLisBox();

                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Kids")
                                    item.Remove();
                                --record;
                            }

                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (CategorycheckedListBox.GetItemChecked(3) == true && secret == 3)
            {

                UncheckedCategorycheckedLisBox();
                CategorycheckedListBox.SetItemChecked(3, true);

                AddAllItems();
                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 3)
                {
                    ItemsListView.Items.Clear();
                    record = 0;
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }
        }

        private void MencheckedListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int check = 0;
            int secret = 0;
            int secret1 = 0;
            for (int i = 0; i < MencheckedListBox.Items.Count; ++i)
            {
                if (MencheckedListBox.GetSelected(i))
                {
                    secret = i;
                    secret1 = i;
                    break;
                }
            }

            if (MencheckedListBox.GetItemChecked(0) == true && secret == 0)
            {
                DisableCategory2checkedListBox();
                Category2lbl.Enabled = true;
                Category2lbl.Text = "Westren Wear";
                Men_western_checkedListBox.Enabled = true;
                Men_western_checkedListBox.BringToFront();
                UncheckedCategory1_MencheckedLisBox();
                MencheckedListBox.SetItemCheckState(0, CheckState.Checked);
                Men_western_checkedListBox.BringToFront();

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Westren Clothing")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 != "Westren Clothing")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;

            }
            else
            {
                if (secret1 == 0)
                {
                    Men_western_checkedListBox.Enabled = false;
                    UncheckedCategory2_Men_westerncheckedLisBox();
                    Category2lbl.Enabled = false;
                    Category2lbl.Text = "Category2";

                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Westren Clothing")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

            if (MencheckedListBox.GetItemChecked(1) == true && secret == 1)
            {
                DisableCategory2checkedListBox();
                Category2lbl.Enabled = true;
                Category2lbl.Text = "Pakistani Wear";
                Men_pakistani_checkedListBox.Enabled = true;
                Men_western_checkedListBox.BringToFront();
                UncheckedCategory1_MencheckedLisBox();
                MencheckedListBox.SetItemCheckState(1, CheckState.Checked);
                Men_pakistani_checkedListBox.BringToFront();

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Pakistani Clothing")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 != "Pakistani Clothing")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 1)
                {
                    Men_pakistani_checkedListBox.Enabled = false;
                    UncheckedCategory2_Men_pakistanicheckedLisBox();
                    Category2lbl.Enabled = false;
                    Category2lbl.Text = "Category2";

                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Pakistani Clothing")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }
            if (MencheckedListBox.GetItemChecked(2) == true && secret == 2)
            {
                DisableCategory2checkedListBox();
                Category2lbl.Enabled = true;
                Category2lbl.Text = "Winter Wear";
                Men_winter_checkedListBox.Enabled = true;
                Men_western_checkedListBox.BringToFront();
                UncheckedCategory1_MencheckedLisBox();
                MencheckedListBox.SetItemCheckState(2, CheckState.Checked);
                Men_winter_checkedListBox.BringToFront();

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Winter Wear")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 != "Winter Wear")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;

                return;

            }
            else
            {
                if (secret1 == 2)
                {
                    Men_winter_checkedListBox.Enabled = false;
                    UncheckedCategory2_Men_wintercheckedLisBox();
                    Category2lbl.Enabled = false;
                    Category2lbl.Text = "Category2";

                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Winter Wear")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }
            if (MencheckedListBox.GetItemChecked(3) == true && secret == 3)
            {
                DisableCategory2checkedListBox();
                Category2lbl.Enabled = true;
                Category2lbl.Text = "Shoes";
                Men_shoes_checkedListBox.Enabled = true;
                Men_western_checkedListBox.BringToFront();
                UncheckedCategory1_MencheckedLisBox();
                MencheckedListBox.SetItemCheckState(3, CheckState.Checked);
                Men_shoes_checkedListBox.BringToFront();

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Shoes")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 != "Shoes")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;

                return;
            }
            else
            {
                if (secret1 == 3)
                {
                    Men_shoes_checkedListBox.Enabled = false;
                    UnselectedCategory2_Men_shoescheckedLisBox();
                    Category2lbl.Enabled = false;
                    Category2lbl.Text = "Category2";

                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Shoes")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }
            if (MencheckedListBox.GetItemChecked(4) == true && secret == 4)
            {
                DisableCategory2checkedListBox();
                Category2lbl.Enabled = true;
                Category2lbl.Text = "Watches";
                Men_watches_checkedListBox.Enabled = true;
                Men_western_checkedListBox.BringToFront();
                UncheckedCategory1_MencheckedLisBox();
                MencheckedListBox.SetItemCheckState(4, CheckState.Checked);
                Men_watches_checkedListBox.BringToFront();

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Watches")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 != "Watches")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;

                return;
            }
            else
            {
                if (secret1 == 4)
                {
                    Men_watches_checkedListBox.Enabled = false;
                    UncheckedCategory2_Men_watchescheckedLisBox();
                    Category2lbl.Enabled = false;
                    Category2lbl.Text = "Category2";

                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Watches")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }
            if (MencheckedListBox.GetItemChecked(5) == true && secret == 5)
            {
                DisableCategory2checkedListBox();
                Category2lbl.Enabled = true;
                Category2lbl.Text = "Accessories";
                Men_accessories_checkedListBox.Enabled = true;
                Men_western_checkedListBox.BringToFront();
                UncheckedCategory1_MencheckedLisBox();
                MencheckedListBox.SetItemCheckState(5, CheckState.Checked);
                Men_accessories_checkedListBox.BringToFront();

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Accessories")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 != "Accessories")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;

                return;
            }
            else
            {
                if (secret1 == 5)
                {
                    Men_accessories_checkedListBox.Enabled = false;
                    UncheckedCategory2_Men_accessoriescheckedLisBox();
                    Category2lbl.Enabled = false;
                    Category2lbl.Text = "Category2";

                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Accessories")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }
        }

        private void WomencheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secret = 0;
            int secret1 = 0;
            for (int i = 0; i < WomencheckedListBox.Items.Count; ++i)
            {
                if (WomencheckedListBox.GetSelected(i))
                {
                    secret = i;
                    secret1 = i;
                    break;
                }
            }


            int check = 0;

            if (WomencheckedListBox.GetItemChecked(0) == true && secret == 0)
            {
                DisableCategory2checkedListBox();
                Women_western_checkedListBox.Enabled = true;
                Category2lbl.Enabled = true;
                Category2lbl.Text = "Westren Wear";
                UncheckedCategory1_WomencheckedLisBox();
                WomencheckedListBox.SetItemCheckState(0, CheckState.Checked);
                Women_western_checkedListBox.BringToFront();
                //++secret;

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Westren Clothing")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 != "Westren Clothing")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 0)
                {
                    Women_western_checkedListBox.Enabled = false;
                    UncheckedCategory2_Women_westerncheckedLisBox();
                    Category2lbl.Enabled = false;
                    Category2lbl.Text = "Category2";

                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Westren Clothing")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

            if (WomencheckedListBox.GetItemChecked(1) == true && secret == 1)
            {
                DisableCategory2checkedListBox();
                Women_pakistani_checkedListBox.Enabled = true;
                Category2lbl.Enabled = true;
                Category2lbl.Text = "Pakistani Wear";
                UncheckedCategory1_WomencheckedLisBox();
                WomencheckedListBox.SetItemCheckState(1, CheckState.Checked);
                Women_pakistani_checkedListBox.BringToFront();
                //++secret;

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Pakistani Clothing")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 != "Pakistani Clothing")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 1)
                {
                    Women_pakistani_checkedListBox.Enabled = false;
                    UncheckedCategory2_Women_pakistanicheckedLisBox();
                    Category2lbl.Enabled = false;
                    Category2lbl.Text = "Category2";

                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Pakistani Clothing")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }
            if (WomencheckedListBox.GetItemChecked(2) == true && secret == 2)
            {
                DisableCategory2checkedListBox();
                Women_winter_checkedListBox.Enabled = true;
                Category2lbl.Enabled = true;
                Category2lbl.Text = "Winter Wear";
                UncheckedCategory1_WomencheckedLisBox();
                WomencheckedListBox.SetItemCheckState(2, CheckState.Checked);
                Women_winter_checkedListBox.BringToFront();
                //++secret;

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Winter Wear")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 != "Winter Wear")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 2)
                {
                    Women_winter_checkedListBox.Enabled = false;
                    UncheckedCategory2_Women_wintercheckedLisBox();
                    Category2lbl.Enabled = false;
                    Category2lbl.Text = "Category2";

                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Winter Wear")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }
            if (WomencheckedListBox.GetItemChecked(3) == true && secret == 3)
            {
                DisableCategory2checkedListBox();
                Women_shoes_checkedListBox.Enabled = true;
                Category2lbl.Enabled = true;
                Category2lbl.Text = "Shoes";
                UncheckedCategory1_WomencheckedLisBox();
                WomencheckedListBox.SetItemCheckState(3, CheckState.Checked);
                Women_shoes_checkedListBox.BringToFront();
                //++secret;

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Shoes")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 != "Shoes")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 3)
                {
                    Women_shoes_checkedListBox.Enabled = false;
                    UncheckedCategory2_Women_shoescheckedLisBox();
                    Category2lbl.Enabled = false;
                    Category2lbl.Text = "Category2";


                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Shoes")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

            if (WomencheckedListBox.GetItemChecked(4) == true && secret == 4)
            {
                DisableCategory2checkedListBox();
                Women_watches_checkedListBox.Enabled = true;
                Category2lbl.Enabled = true;
                Category2lbl.Text = "Watches";
                UncheckedCategory1_WomencheckedLisBox();
                WomencheckedListBox.SetItemCheckState(4, CheckState.Checked);
                Women_watches_checkedListBox.BringToFront();

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Watches")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 != "Watches")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 4)
                {
                    Women_watches_checkedListBox.Enabled = false;
                    UncheckedCategory2_Women_watchescheckedLisBox();
                    Category2lbl.Enabled = false;
                    Category2lbl.Text = "Category2";


                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Watches")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }
            if (WomencheckedListBox.GetItemChecked(5) == true && secret == 5)
            {
                DisableCategory2checkedListBox();
                Women_accessories_checkedListBox.Enabled = true;
                Category2lbl.Enabled = true;
                Category2lbl.Text = "Accessories";
                UncheckedCategory1_WomencheckedLisBox();
                WomencheckedListBox.SetItemCheckState(5, CheckState.Checked);
                Women_accessories_checkedListBox.BringToFront();

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Accessories")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 != "Accessories")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 5)
                {
                    Women_accessories_checkedListBox.Enabled = false;
                    UncheckedCategory2_Women_accessoriescheckedLisBox();
                    Category2lbl.Enabled = false;
                    Category2lbl.Text = "Category2";

                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Accessories")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }
        }

        private void KidscheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check = 0;
            int secret = 0;
            int secret1 = 0;
            for (int i = 0; i < KidscheckedListBox.Items.Count; ++i)
            {
                if (KidscheckedListBox.GetSelected(i))
                {
                    secret = i;
                    secret1 = i;
                    break;
                }
            }
            if (KidscheckedListBox.GetItemChecked(0) == true && secret == 0)
            {
                DisableCategory2_KidscheckedListBox();
                Category2lbl.Enabled = true;
                Category2lbl.Text = "Boy";
                Kids_BoycheckedListBox.Enabled = true;
                Kids_BoycheckedListBox.BringToFront();
                UncheckedCategory1_KidscheckedLisBox();
                KidscheckedListBox.SetItemChecked(0, true);

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Boy")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 != "Boy")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 0)
                {
                    Kids_BoycheckedListBox.Enabled = false;
                    UncheckedCategory2_Kids_BoycheckedLisBox();
                    Category2lbl.Enabled = false;
                    Category2lbl.Text = "Category2";

                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Boy")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (KidscheckedListBox.GetItemChecked(1) == true && secret == 1)
            {
                DisableCategory2_KidscheckedListBox();
                Category2lbl.Enabled = true;
                Category2lbl.Text = "Girl";
                Kids_GirlcheckedListBox.Enabled = true;
                UncheckedCategory1_KidscheckedLisBox();
                KidscheckedListBox.SetItemChecked(1, true);
                Kids_GirlcheckedListBox.BringToFront();

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Girl")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 != "Girl")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 1)
                {
                    Kids_GirlcheckedListBox.Enabled = false;
                    UncheckedCategory2_Kids_GirlcheckedLisBox();
                    Category2lbl.Enabled = false;
                    Category2lbl.Text = "Category2";

                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Girl")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (KidscheckedListBox.GetItemChecked(2) == true && secret == 2)
            {
                DisableCategory2_KidscheckedListBox();
                Category2lbl.Enabled = true;
                Category2lbl.Text = "Baby";
                Kids_BabycheckedListBox.Enabled = true;
                UncheckedCategory1_KidscheckedLisBox();
                KidscheckedListBox.SetItemChecked(2, true);
                Kids_BabycheckedListBox.BringToFront();

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Baby")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 != "Baby")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 2)
                {
                    Kids_BabycheckedListBox.Enabled = false;
                    UncheckedCategory2_Kids_BabycheckedLisBox();
                    Category2lbl.Enabled = false;
                    Category2lbl.Text = "Category2";

                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Baby")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }
        }

        private void Women_pakistani_checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check = 0;
            int secret = 0;
            int secret1 = 0;
            for (int i = 0; i < Women_pakistani_checkedListBox.Items.Count; ++i)
            {
                if (Women_pakistani_checkedListBox.GetSelected(i))
                {
                    secret = i;
                    secret1 = i;
                    break;
                }
            }

            if (Women_pakistani_checkedListBox.GetItemChecked(0) && secret == 0)
            {
                UncheckedCategory2_Women_pakistanicheckedLisBox();
                Women_pakistani_checkedListBox.SetItemChecked(0, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 == "Kurtas and Shalwar Kamiz")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 != "Kurtas and Shalwar Kamiz")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 0)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 == "Kurtas and Shalwar Kamiz")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }


            if (Women_pakistani_checkedListBox.GetItemChecked(1) && secret == 1)
            {
                UncheckedCategory2_Women_pakistanicheckedLisBox();
                Women_pakistani_checkedListBox.SetItemChecked(1, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 == "Formal Wear")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 != "Formal Wear")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 1)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 == "Formal Wear")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }


            if (Women_pakistani_checkedListBox.GetItemChecked(2) && secret == 2)
            {
                UncheckedCategory2_Women_pakistanicheckedLisBox();
                Women_pakistani_checkedListBox.SetItemChecked(2, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 == "Abbayas and Hijabs")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 != "Abbayas and Hijabs")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 2)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 == "Abbayas and Hijabs")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }


            if (Women_pakistani_checkedListBox.GetItemChecked(3) && secret == 3)
            {
                UncheckedCategory2_Women_pakistanicheckedLisBox();
                Women_pakistani_checkedListBox.SetItemChecked(3, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 == "Dupattas and Shawls")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 != "Dupattas and Shawls")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 3)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 == "Dupattas and Shawls")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }

            }

            if (Women_pakistani_checkedListBox.GetItemChecked(4) && secret == 4)
            {
                UncheckedCategory2_Women_pakistanicheckedLisBox();
                Women_pakistani_checkedListBox.SetItemChecked(4, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 == "Pants and Plazzoes")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 != "Pants and Plazzoes")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 4)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 == "Pants and Plazzoes")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }


        }

        private void Women_western_checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check = 0;
            int secret = 0, secret1 = 0;
            for (int i = 0; i < Women_western_checkedListBox.Items.Count; ++i)
            {
                if (Women_western_checkedListBox.GetSelected(i))
                {
                    secret = i;
                    secret1 = i;
                    break;
                }
            }

            if (Women_western_checkedListBox.GetItemChecked(0) && secret == 0)
            {
                UncheckedCategory2_Women_westerncheckedLisBox();
                Women_western_checkedListBox.SetItemChecked(0, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 == "Tops and Shirts")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 != "Tops and Shirts")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 0)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 == "Tops and Shirts")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }

            }

            if (Women_western_checkedListBox.GetItemChecked(1) && secret == 1)
            {
                UncheckedCategory2_Women_westerncheckedLisBox();
                Women_western_checkedListBox.SetItemChecked(1, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 == "T-Shirts")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 != "T-Shirts")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 1)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 == "T-Shirts")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }

            }

            if (Women_western_checkedListBox.GetItemChecked(2) && secret == 2)
            {
                UncheckedCategory2_Women_westerncheckedLisBox();
                Women_western_checkedListBox.SetItemChecked(2, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 == "Bottoms and Tights")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 != "Bottoms and Tights")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 2)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 == "Bottoms and Tights")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

            if (Women_western_checkedListBox.GetItemChecked(3) && secret == 3)
            {
                UncheckedCategory2_Women_westerncheckedLisBox();
                Women_western_checkedListBox.SetItemChecked(3, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 == "Jeans")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 != "Jeans")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 3)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 == "Jeans")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

        }

        private void Women_shoes_checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check = 0;
            int secret = 0, secret1 = 0;
            for (int i = 0; i < Women_shoes_checkedListBox.Items.Count; ++i)
            {
                if (Women_shoes_checkedListBox.GetSelected(i))
                {
                    secret = i;
                    secret1 = i;
                    break;
                }
            }
            if (Women_shoes_checkedListBox.GetItemChecked(0) && secret == 0)
            {
                UncheckedCategory2_Women_shoescheckedLisBox();
                Women_shoes_checkedListBox.SetItemChecked(0, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 == "Sandals")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 != "Sandals")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 0)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 == "Sandals")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }

            }

            if (Women_shoes_checkedListBox.GetItemChecked(1) && secret == 1)
            {
                UncheckedCategory2_Women_shoescheckedLisBox();
                Women_shoes_checkedListBox.SetItemChecked(1, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 == "Slippers")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 != "Slippers")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 1)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 == "Slippers")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

            if (Women_shoes_checkedListBox.GetItemChecked(2) && secret == 2)
            {
                UncheckedCategory2_Women_shoescheckedLisBox();
                Women_shoes_checkedListBox.SetItemChecked(2, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 == "Khussa")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 != "Khussa")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 2)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 == "Khussa")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

            if (Women_shoes_checkedListBox.GetItemChecked(3) && secret == 3)
            {
                UncheckedCategory2_Women_shoescheckedLisBox();
                Women_shoes_checkedListBox.SetItemChecked(3, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 == "Heels")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 != "Heels")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 3)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 == "Heels")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

            if (Women_shoes_checkedListBox.GetItemChecked(4) && secret == 4)
            {
                UncheckedCategory2_Women_shoescheckedLisBox();
                Women_shoes_checkedListBox.SetItemChecked(4, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 == "Pumps")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 != "Pumps")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 4)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 == "Pumps")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

            if (Women_shoes_checkedListBox.GetItemChecked(5) && secret == 5)
            {
                UncheckedCategory2_Women_shoescheckedLisBox();
                Women_shoes_checkedListBox.SetItemChecked(5, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 == "Sneakers")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 != "Sneakers")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 5)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 == "Sneakers")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }
        }

        private void Women_watches_checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check = 0;
            int secret = 0, secret1 = 0;
            for (int i = 0; i < Women_watches_checkedListBox.Items.Count; ++i)
            {
                if (Women_watches_checkedListBox.GetSelected(i))
                {
                    secret = i;
                    secret1 = i;
                    break;
                }
            }
            if (Women_watches_checkedListBox.GetItemChecked(0) && secret == 0)
            {
                UncheckedCategory2_Women_watchescheckedLisBox();
                Women_watches_checkedListBox.SetItemChecked(0, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 == "Smart")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 != "Smart")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 0)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 == "Smart")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

            if (Women_watches_checkedListBox.GetItemChecked(1) && secret == 1)
            {
                UncheckedCategory2_Women_watchescheckedLisBox();
                Women_watches_checkedListBox.SetItemChecked(1, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 == "Analog")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 != "Analog")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 1)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 == "Analog")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

            if (Women_watches_checkedListBox.GetItemChecked(2) && secret == 2)
            {
                UncheckedCategory2_Women_watchescheckedLisBox();
                Women_watches_checkedListBox.SetItemChecked(2, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 == "Cornograph")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 != "Cornograph")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 2)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 == "Cornograph")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }


            if (Women_watches_checkedListBox.GetItemChecked(3) && secret == 3)
            {
                UncheckedCategory2_Women_watchescheckedLisBox();
                Women_watches_checkedListBox.SetItemChecked(3, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 == "Digital")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 != "Digital")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 3)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 == "Digital")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

        }

        private void Women_accessories_checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check = 0;
            int secret = 0, secret1 = 0;
            for (int i = 0; i < Women_accessories_checkedListBox.Items.Count; ++i)
            {
                if (Women_accessories_checkedListBox.GetSelected(i))
                {
                    secret = i;
                    secret1 = i;
                    break;
                }
            }
            if (Women_accessories_checkedListBox.GetItemChecked(0) && secret == 0)
            {
                UncheckedCategory2_Women_accessoriescheckedLisBox();
                Women_accessories_checkedListBox.SetItemChecked(0, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 == "Eye Wear")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 != "Eye Wear")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 0)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 == "Eye Wear")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }


            if (Women_accessories_checkedListBox.GetItemChecked(1) && secret == 1)
            {
                UncheckedCategory2_Women_accessoriescheckedLisBox();
                Women_accessories_checkedListBox.SetItemChecked(1, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 == "Bags")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 != "Bags")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 1)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 == "Bags")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }


            if (Women_accessories_checkedListBox.GetItemChecked(2) && secret == 2)
            {
                UncheckedCategory2_Women_accessoriescheckedLisBox();
                Women_accessories_checkedListBox.SetItemChecked(2, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 == "Scarves and Mufflers")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 != "Scarves and Mufflers")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 2)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 == "Scarves and Mufflers")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }


            if (Women_accessories_checkedListBox.GetItemChecked(3) && secret == 3)
            {
                UncheckedCategory2_Women_accessoriescheckedLisBox();
                Women_accessories_checkedListBox.SetItemChecked(3, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 == "Jwellery")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 != "Jwellery")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 3)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 == "Jwellery")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }
        }

        private void Women_winter_checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check = 0;
            int secret = 0, secret1 = 0;
            for (int i = 0; i < Women_winter_checkedListBox.Items.Count; ++i)
            {
                if (Women_winter_checkedListBox.GetSelected(i))
                {
                    secret = i;
                    secret1 = i;
                    break;
                }
            }
            if (Women_winter_checkedListBox.GetItemChecked(0) && secret == 0)
            {
                UncheckedCategory2_Women_wintercheckedLisBox();
                Women_winter_checkedListBox.SetItemChecked(0, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Winter Wear" && ProductUC.itemList[i].category2 == "Jackets and Coats")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Winter Wear" && ProductUC.itemList[i].category2 != "Jackets and Coats")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 0)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Winter Wear" && ProductUC.itemList[i].category2 == "Jackets and Coats")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }


            if (Women_winter_checkedListBox.GetItemChecked(1) && secret == 1)
            {
                UncheckedCategory2_Women_wintercheckedLisBox();
                Women_winter_checkedListBox.SetItemChecked(1, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Winter Wear" && ProductUC.itemList[i].category2 == "Hoodies")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Winter Wear" && ProductUC.itemList[i].category2 != "Hoodies")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 1)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Women" && ProductUC.itemList[i].category1 == "Winter Wear" && ProductUC.itemList[i].category2 == "Hoodies")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

        }

        private void ColorcheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check = 0;
            //int secret = 0;
            int secret1 = 0;
            for (int i = 0; i < ColorcheckedListBox.Items.Count; ++i)
            {
                if (ColorcheckedListBox.GetSelected(i))
                {
                    //secret = i;
                    secret1 = i;
                    break;
                }
            }
            if (ColorcheckedListBox.GetItemChecked(0))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Red".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 0)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Red".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }




            if (ColorcheckedListBox.GetItemChecked(1))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Blue".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 1)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Blue".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }


            if (ColorcheckedListBox.GetItemChecked(2))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Green".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 2)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Green".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (ColorcheckedListBox.GetItemChecked(3))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "White".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 3)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "White".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (ColorcheckedListBox.GetItemChecked(4))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Skin".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 4)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Skin".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (ColorcheckedListBox.GetItemChecked(5))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Golden".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 5)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Golden".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (ColorcheckedListBox.GetItemChecked(6))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Tan".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 6)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Tan".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (ColorcheckedListBox.GetItemChecked(7))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Black".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 7)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Black".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (ColorcheckedListBox.GetItemChecked(8))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Orange".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 8)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Orange".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (ColorcheckedListBox.GetItemChecked(9))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Brown".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 9)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Brown".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (ColorcheckedListBox.GetItemChecked(10))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Grey".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 10)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Grey".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (ColorcheckedListBox.GetItemChecked(11))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Multicolor".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 11)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Multicolor".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (ColorcheckedListBox.GetItemChecked(12))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Pink".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 12)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Pink".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (ColorcheckedListBox.GetItemChecked(13))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Maroon".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 13)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Maroon".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (ColorcheckedListBox.GetItemChecked(14))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Mojari".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 14)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Mojari".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (ColorcheckedListBox.GetItemChecked(15))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Cream".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 15)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].color.ToUpper(), "Cream".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

        }

        private void MaterialcheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check;
            //int secret = 0;
            int secret1 = 0;
            for (int i = 0; i < MaterialcheckedListBox.Items.Count; ++i)
            {
                if (MaterialcheckedListBox.GetSelected(i))
                {
                    //secret = i;
                    secret1 = i;
                    break;
                }
            }
            if (MaterialcheckedListBox.GetItemChecked(0))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].material.ToUpper(), "Cotton".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 0)
                {
                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(item.SubItems[6].Text.ToUpper(), "Cotton".ToUpper()))
                        {
                            item.Remove();
                            --record;
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (MaterialcheckedListBox.GetItemChecked(1))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].material.ToUpper(), "Linen".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 1)
                {
                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(item.SubItems[6].Text.ToUpper(), "Linen".ToUpper()))
                        {
                            item.Remove();
                            --record;
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (MaterialcheckedListBox.GetItemChecked(2))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].material.ToUpper(), "Silic".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 2)
                {
                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(item.SubItems[6].Text.ToUpper(), "Silic".ToUpper()))
                        {
                            item.Remove();
                            --record;
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (MaterialcheckedListBox.GetItemChecked(3))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].material.ToUpper(), "Valvet".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 3)
                {
                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(item.SubItems[6].Text.ToUpper(), "Valvet".ToUpper()))
                        {
                            item.Remove();
                            --record;
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (MaterialcheckedListBox.GetItemChecked(4))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].material.ToUpper(), "Plastic".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 4)
                {
                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(item.SubItems[6].Text.ToUpper(), "Plastic".ToUpper()))
                        {
                            item.Remove();
                            --record;
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (MaterialcheckedListBox.GetItemChecked(5))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].material.ToUpper(), "Rubber".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 5)
                {
                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(item.SubItems[6].Text.ToUpper(), "Rubber".ToUpper()))
                        {
                            item.Remove();
                            --record;
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (MaterialcheckedListBox.GetItemChecked(6))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].material.ToUpper(), "Synthetic".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 6)
                {
                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(item.SubItems[6].Text.ToUpper(), "Synthetic".ToUpper()))
                        {
                            item.Remove();
                            --record;
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (MaterialcheckedListBox.GetItemChecked(7))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].material.ToUpper(), "Leather".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 7)
                {
                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(item.SubItems[6].Text.ToUpper(), "Leather".ToUpper()))
                        {
                            item.Remove();
                            --record;
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (MaterialcheckedListBox.GetItemChecked(8))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].material.ToUpper(), "Metal".ToUpper()))
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 8)
                {
                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(item.SubItems[6].Text.ToUpper(), "Metal".ToUpper()))
                        {
                            item.Remove();
                            --record;
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (MaterialcheckedListBox.GetItemChecked(9))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].material.ToUpper(), "Steel".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 9)
                {
                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(item.SubItems[6].Text.ToUpper(), "Steel".ToUpper()))
                        {
                            item.Remove();
                            --record;
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }

            if (MaterialcheckedListBox.GetItemChecked(10))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].material.ToUpper(), "Alloy".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 10)
                {
                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(item.SubItems[6].Text.ToUpper(), "Alloy".ToUpper()))
                        {
                            item.Remove();
                            --record;
                        }
                    }
                    ItemRecordlbl.Text = "Total record = " + record;
                }
            }
        }

        private void ClothingcheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check = 0;
            int secret1 = 0;
            for (int i = 0; i < ClothingcheckedListBox.Items.Count; ++i)
            {
                if (ClothingcheckedListBox.GetSelected(i))
                {
                    //secret = i;
                    secret1 = i;
                    break;
                }
            }

            if (ClothingcheckedListBox.GetItemChecked(0))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Kurtas and Shalwar Kamiz".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 0)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Kurtas and Shalwar Kamiz".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }

                        }
                    }
                } ItemRecordlbl.Text = "Total record = " + record;
            }

            if (ClothingcheckedListBox.GetItemChecked(1))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Formal".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 1)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Formal".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }

                        }
                    }
                } ItemRecordlbl.Text = "Total record = " + record;
            }

            if (ClothingcheckedListBox.GetItemChecked(2))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Abbayas and Hijabs".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 2)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Abbayas and Hijabs".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }

                        }
                    }
                } ItemRecordlbl.Text = "Total record = " + record;
            }

            if (ClothingcheckedListBox.GetItemChecked(3))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Dupattas and Shawls".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 3)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Dupattas and Shawls".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }

                        }
                    }
                } ItemRecordlbl.Text = "Total record = " + record;
            }

            if (ClothingcheckedListBox.GetItemChecked(4))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Pants and Plazzoes".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 4)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Pants and Plazzoes".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }

                        }
                    }
                } ItemRecordlbl.Text = "Total record = " + record;
            }

            if (ClothingcheckedListBox.GetItemChecked(5))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if ((System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Tops and Shirts".ToUpper()))
                        || (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Shirts".ToUpper()))
                        || (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Tops".ToUpper())))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 5)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if ((System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Tops and Shirts".ToUpper()))
                                    || (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Shirts".ToUpper()))
                                    || (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Tops".ToUpper())))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }

                        }
                    }
                } ItemRecordlbl.Text = "Total record = " + record;
            }

            if (ClothingcheckedListBox.GetItemChecked(6))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "T-Shirts".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {

                if (secret1 == 6)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "T-Shirts".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }

                        }
                    }
                } ItemRecordlbl.Text = "Total record = " + record;
            }

            if (ClothingcheckedListBox.GetItemChecked(7))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if ((System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Bottoms and Tights".ToUpper()))
                        || (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Bottoms".ToUpper()))
                        || (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Tights".ToUpper())))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 7)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if ((System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Bottoms and Tights".ToUpper()))
                                    || (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Bottoms".ToUpper()))
                                    || (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Tights".ToUpper())))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }

                        }
                    }
                } ItemRecordlbl.Text = "Total record = " + record;
            }

            if (ClothingcheckedListBox.GetItemChecked(8))
            {

                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Jeans".ToUpper()))
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }
                }
                ItemRecordlbl.Text = "Total record = " + record;
            }
            else
            {
                if (secret1 == 8)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {

                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(ProductUC.itemList[i].category2.ToUpper(), "Jeans".ToUpper()))
                                {
                                    item.Remove();
                                    --record;
                                }
                            }

                        }
                    }
                } ItemRecordlbl.Text = "Total record = " + record;

            }
        }

        private void Men_pakistani_checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check = 0;
            int secret = 0;
            int secret1 = 0;
            for (int i = 0; i < Men_pakistani_checkedListBox.Items.Count; ++i)
            {
                if (Men_pakistani_checkedListBox.GetSelected(i))
                {
                    secret = i;
                    secret1 = i;
                    break;
                }
            }

            if (Men_pakistani_checkedListBox.GetItemChecked(0) && secret == 0)
            {
                UncheckedCategory2_Men_pakistanicheckedLisBox();
                Men_pakistani_checkedListBox.SetItemChecked(0, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 == "Shalwar Kamiz")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 != "Shalwar Kamiz")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 0)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 == "Shalwar Kamiz")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }


            if (Men_pakistani_checkedListBox.GetItemChecked(1) && secret == 1)
            {
                UncheckedCategory2_Men_pakistanicheckedLisBox();
                Men_pakistani_checkedListBox.SetItemChecked(1, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 == "Kurtas")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 != "Kurtas")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 1)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 == "Kurtas")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }


            if (Men_pakistani_checkedListBox.GetItemChecked(2) && secret == 2)
            {
                UncheckedCategory2_Men_pakistanicheckedLisBox();
                Men_pakistani_checkedListBox.SetItemChecked(2, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 == "WaistCoat")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 != "WaistCoat")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 2)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 == "WaistCoat")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }


            if (Men_pakistani_checkedListBox.GetItemChecked(3) && secret == 3)
            {
                UncheckedCategory2_Men_pakistanicheckedLisBox();
                Men_pakistani_checkedListBox.SetItemChecked(3, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 == "Unstiched")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 != "Unstiched")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 3)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Pakistani Clothing" && ProductUC.itemList[i].category2 == "Unstiched")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }

            }
        }

        private void Men_western_checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check = 0;
            int secret = 0;
            int secret1 = 0;
            for (int i = 0; i < Men_western_checkedListBox.Items.Count; ++i)
            {
                if (Men_western_checkedListBox.GetSelected(i))
                {
                    secret = i;
                    secret1 = i;
                    break;
                }
            }

            if (Men_western_checkedListBox.GetItemChecked(0) && secret == 0)
            {
                UncheckedCategory2_Men_westerncheckedLisBox();
                Men_western_checkedListBox.SetItemChecked(0, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 == "T-Shirts")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 != "T-Shirts")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 0)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 == "T-Shirts")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }


            if (Men_western_checkedListBox.GetItemChecked(1) && secret == 1)
            {
                UncheckedCategory2_Men_westerncheckedLisBox();
                Men_western_checkedListBox.SetItemChecked(1, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 == "Polo")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 != "Polo")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 1)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 == "Polo")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }


            if (Men_western_checkedListBox.GetItemChecked(2) && secret == 2)
            {
                UncheckedCategory2_Men_westerncheckedLisBox();
                Men_western_checkedListBox.SetItemChecked(2, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 == "Tops and Shirts")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 != "Tops and Shirts")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 2)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 == "Tops and Shirts")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }


            if (Men_western_checkedListBox.GetItemChecked(3) && secret == 3)
            {
                UncheckedCategory2_Men_westerncheckedLisBox();
                Men_western_checkedListBox.SetItemChecked(3, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 == "Trousers and Pants")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 != "Trousers and Pants")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 3)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 == "Trousers and Pants")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }

            }

            if (Men_western_checkedListBox.GetItemChecked(4) && secret == 4)
            {
                UncheckedCategory2_Men_westerncheckedLisBox();
                Men_western_checkedListBox.SetItemChecked(4, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 == "Jeans")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 != "Jeans")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 4)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 == "Jeans")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }

            }

            if (Men_western_checkedListBox.GetItemChecked(5) && secret == 5)
            {
                UncheckedCategory2_Men_westerncheckedLisBox();
                Men_western_checkedListBox.SetItemChecked(5, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 == "Shorts")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 != "Shorts")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 5)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Westren Clothing" && ProductUC.itemList[i].category2 == "Shorts")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }

            }
        }

        private void Men_accessories_checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check = 0, secret = 0, secret1 = 0;
            for (int i = 0; i < Men_accessories_checkedListBox.Items.Count; ++i)
            {
                if (Men_accessories_checkedListBox.GetSelected(i))
                {
                    secret = i;
                    secret1 = i;
                    break;
                }
            }

            if (Men_accessories_checkedListBox.GetItemChecked(0) && secret == 0)
            {
                UncheckedCategory2_Men_accessoriescheckedLisBox();
                Men_accessories_checkedListBox.SetItemChecked(0, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 == "Wallets and Cardholders")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 != "Wallets and Cardholders")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 0)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 == "Wallets and Cardholders")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }

            }

            if (Men_accessories_checkedListBox.GetItemChecked(1) && secret == 1)
            {
                UncheckedCategory2_Men_accessoriescheckedLisBox();
                Men_accessories_checkedListBox.SetItemChecked(1, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 == "Ties and Cufflins")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 != "Ties and Cufflins")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 1)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 == "Ties and Cufflins")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }


            if (Men_accessories_checkedListBox.GetItemChecked(2) && secret == 2)
            {
                UncheckedCategory2_Men_accessoriescheckedLisBox();
                Men_accessories_checkedListBox.SetItemChecked(2, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 == "Eye Wear")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 != "Eye Wear")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 2)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 == "Eye Wear")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }


            if (Men_accessories_checkedListBox.GetItemChecked(3) && secret == 3)
            {
                UncheckedCategory2_Men_accessoriescheckedLisBox();
                Men_accessories_checkedListBox.SetItemChecked(3, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 == "Bags")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 != "Bags")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 3)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 == "Bags")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

            if (Men_accessories_checkedListBox.GetItemChecked(4) && secret == 4)
            {
                UncheckedCategory2_Men_accessoriescheckedLisBox();
                Men_accessories_checkedListBox.SetItemChecked(4, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 == "Belts")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 != "Belts")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 4)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 == "Belts")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

            if (Men_accessories_checkedListBox.GetItemChecked(5) && secret == 5)
            {
                UncheckedCategory2_Men_accessoriescheckedLisBox();
                Men_accessories_checkedListBox.SetItemChecked(5, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;
                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 == "Caps and Gloves")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 != "Caps and Gloves")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 5)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Accessories" && ProductUC.itemList[i].category2 == "Caps and Gloves")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }
        }

        private void Men_watches_checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check = 0, secret = 0, secret1 = 0;
            for (int i = 0; i < Men_watches_checkedListBox.Items.Count; ++i)
            {
                if (Men_watches_checkedListBox.GetSelected(i))
                {
                    secret = i;
                    secret1 = i;
                    break;
                }
            }

            if (Men_watches_checkedListBox.GetItemChecked(0) && secret == 0)
            {
                UncheckedCategory2_Men_watchescheckedLisBox();
                Men_watches_checkedListBox.SetItemChecked(0, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 == "Smart")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 != "Smart")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 0)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 == "Smart")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }

            }


            if (Men_watches_checkedListBox.GetItemChecked(1) && secret == 1)
            {
                UncheckedCategory2_Men_watchescheckedLisBox();
                Men_watches_checkedListBox.SetItemChecked(1, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 == "Analog")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 != "Analog")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 1)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 == "Analog")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }

            }

            if (Men_watches_checkedListBox.GetItemChecked(2) && secret == 2)
            {
                UncheckedCategory2_Men_watchescheckedLisBox();
                Men_watches_checkedListBox.SetItemChecked(2, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 == "Digital")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 != "Digital")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 2)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 == "Digital")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }

            }

            if (Men_watches_checkedListBox.GetItemChecked(3) && secret == 3)
            {
                UncheckedCategory2_Men_watchescheckedLisBox();
                Men_watches_checkedListBox.SetItemChecked(3, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 == "Cornograph")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 != "Cornograph")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 3)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Watches" && ProductUC.itemList[i].category2 == "Cornograph")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }

            }
        }

        private void Men_shoes_checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check = 0, secret = 0, secret1 = 0;
            for (int i = 0; i < Men_shoes_checkedListBox.Items.Count; ++i)
            {
                if (Men_shoes_checkedListBox.GetSelected(i))
                {
                    secret = i;
                    secret1 = i;
                    break;
                }
            }

            if (Men_shoes_checkedListBox.GetItemChecked(1) && secret == 1)
            {
                UncheckedCategory2_Men_shoescheckedLisBox();
                Men_shoes_checkedListBox.SetItemChecked(1, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 == "Casual Shoes")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 != "Casual Shoes")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 1)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 == "Casual Shoes")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }

            }

            if (Men_shoes_checkedListBox.GetItemChecked(2) && secret == 2)
            {
                UncheckedCategory2_Men_shoescheckedLisBox();
                Men_shoes_checkedListBox.SetItemChecked(2, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 == "Formal Shoes")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 != "Formal Shoes")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 2)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 == "Formal Shoes")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }

            }

            if (Men_shoes_checkedListBox.GetItemChecked(3) && secret == 3)
            {
                UncheckedCategory2_Men_shoescheckedLisBox();
                Men_shoes_checkedListBox.SetItemChecked(3, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 == "Sneakers")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 != "Sneakers")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 3)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 == "Sneakers")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }

            }

            if (Men_shoes_checkedListBox.GetItemChecked(4) && secret == 4)
            {
                UncheckedCategory2_Men_shoescheckedLisBox();
                Men_shoes_checkedListBox.SetItemChecked(4, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 == "Boots")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 != "Boots")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 4)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 == "Boots")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }

            }

            if (Men_shoes_checkedListBox.GetItemChecked(0) && secret == 0)
            {
                UncheckedCategory2_Men_shoescheckedLisBox();
                Men_shoes_checkedListBox.SetItemChecked(0, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 == "Sandals and Slippers")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 != "Sandals and Slippers")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 0)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Shoes" && ProductUC.itemList[i].category2 == "Sandals and Slippers")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }

            }
        }

        private void Men_winter_checkedListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int check = 0, secret = 0, secret1 = 0;
            for (int i = 0; i < Men_winter_checkedListBox.Items.Count; ++i)
            {
                if (Men_winter_checkedListBox.GetSelected(i))
                {
                    secret = i;
                    secret1 = i;
                    break;
                }
            }

            if (Men_winter_checkedListBox.GetItemChecked(0) && secret == 0)
            {
                UncheckedCategory2_Men_wintercheckedLisBox();
                Men_winter_checkedListBox.SetItemChecked(0, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Winter Wear" && ProductUC.itemList[i].category2 == "Jackets and Coats")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Winter Wear" && ProductUC.itemList[i].category2 != "Jackets and Coats")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 0)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Winter Wear" && ProductUC.itemList[i].category2 == "Jackets and Coats")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

            if (Men_winter_checkedListBox.GetItemChecked(1) && secret == 1)
            {
                UncheckedCategory2_Men_wintercheckedLisBox();
                Men_winter_checkedListBox.SetItemChecked(1, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Winter Wear" && ProductUC.itemList[i].category2 == "Sweaters")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Winter Wear" && ProductUC.itemList[i].category2 != "Sweaters")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 1)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Winter Wear" && ProductUC.itemList[i].category2 == "Sweaters")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

            if (Men_winter_checkedListBox.GetItemChecked(2) && secret == 2)
            {
                UncheckedCategory2_Men_wintercheckedLisBox();
                Men_winter_checkedListBox.SetItemChecked(2, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Winter Wear" && ProductUC.itemList[i].category2 == "Hoodies")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Winter Wear" && ProductUC.itemList[i].category2 != "Hoodies")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 2)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Men" && ProductUC.itemList[i].category1 == "Winter Wear" && ProductUC.itemList[i].category2 == "Hoodies")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }
        }

        private void Kids_BabycheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check = 0, secret = 0, secret1 = 0;
            for (int i = 0; i < Kids_BabycheckedListBox.Items.Count; ++i)
            {
                if (Kids_BabycheckedListBox.GetSelected(i))
                {
                    secret = i;
                    secret1 = i;
                    break;
                }
            }

            if (Kids_BabycheckedListBox.GetItemChecked(0) && secret == 0)
            {
                UncheckedCategory2_Kids_BabycheckedLisBox();
                Kids_BabycheckedListBox.SetItemChecked(0, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Baby" && ProductUC.itemList[i].category2 == "Clothes")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                        ItemRecordlbl.Text = "Total record = " + record;
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Baby" && ProductUC.itemList[i].category2 != "Clothes")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 0)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Baby" && ProductUC.itemList[i].category2 == "Clothes")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

            if (Kids_BabycheckedListBox.GetItemChecked(1) && secret == 1)
            {
                UncheckedCategory2_Kids_BabycheckedLisBox();
                Kids_BabycheckedListBox.SetItemChecked(1, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Baby" && ProductUC.itemList[i].category2 == "Shoes")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }

                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Baby" && ProductUC.itemList[i].category2 != "Shoes")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 1)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Baby" && ProductUC.itemList[i].category2 == "Shoes")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

            if (Kids_BabycheckedListBox.GetItemChecked(2) && secret == 2)
            {
                UncheckedCategory2_Kids_BabycheckedLisBox();
                Kids_BabycheckedListBox.SetItemChecked(2, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Baby" && ProductUC.itemList[i].category2 == "Accessories")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Baby" && ProductUC.itemList[i].category2 != "Accessories")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 2)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Baby" && ProductUC.itemList[i].category2 == "Accessories")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }
        }

        private void Kids_GirlcheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check = 0, secret = 0, secret1 = 0;
            for (int i = 0; i < Kids_GirlcheckedListBox.Items.Count; ++i)
            {
                if (Kids_GirlcheckedListBox.GetSelected(i))
                {
                    secret = i;
                    secret1 = i;
                    break;
                }
            }

            if (Kids_GirlcheckedListBox.GetItemChecked(0) && secret == 0)
            {
                UncheckedCategory2_Kids_GirlcheckedLisBox();
                Kids_GirlcheckedListBox.SetItemChecked(0, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Girl" && ProductUC.itemList[i].category2 == "Clothes")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Girl" && ProductUC.itemList[i].category2 != "Clothes")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 0)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Girl" && ProductUC.itemList[i].category2 == "Clothes")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

            if (Kids_GirlcheckedListBox.GetItemChecked(1) && secret == 1)
            {
                UncheckedCategory2_Kids_GirlcheckedLisBox();
                Kids_GirlcheckedListBox.SetItemChecked(1, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Girl" && ProductUC.itemList[i].category2 == "Shoes")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Girl" && ProductUC.itemList[i].category2 != "Shoes")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 1)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Girl" && ProductUC.itemList[i].category2 == "Shoes")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

            if (Kids_GirlcheckedListBox.GetItemChecked(2) && secret == 2)
            {
                UncheckedCategory2_Kids_GirlcheckedLisBox();
                Kids_GirlcheckedListBox.SetItemChecked(2, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Girl" && ProductUC.itemList[i].category2 == "Accessories")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Girl" && ProductUC.itemList[i].category2 != "Accessories")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 2)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Girl" && ProductUC.itemList[i].category2 == "Accessories")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }
        }

        private void Kids_BoycheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check = 0, secret = 0, secret1 = 0;
            for (int i = 0; i < Kids_BoycheckedListBox.Items.Count; ++i)
            {
                if (Kids_BoycheckedListBox.GetSelected(i))
                {
                    secret = i;
                    secret1 = i;
                    break;
                }
            }

            if (Kids_BoycheckedListBox.GetItemChecked(0) && secret == 0)
            {
                UncheckedCategory2_Kids_BoycheckedLisBox();
                Kids_BoycheckedListBox.SetItemChecked(0, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Boy" && ProductUC.itemList[i].category2 == "Clothes")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Boy" && ProductUC.itemList[i].category2 != "Clothes")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 0)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Boy" && ProductUC.itemList[i].category2 == "Clothes")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

            if (Kids_BoycheckedListBox.GetItemChecked(1) && secret == 1)
            {
                UncheckedCategory2_Kids_BoycheckedLisBox();
                Kids_BoycheckedListBox.SetItemChecked(1, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Boy" && ProductUC.itemList[i].category2 == "Shoes")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Boy" && ProductUC.itemList[i].category2 != "Shoes")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 1)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Boy" && ProductUC.itemList[i].category2 == "Shoes")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }

            if (Kids_BoycheckedListBox.GetItemChecked(2) && secret == 2)
            {
                UncheckedCategory2_Kids_BoycheckedLisBox();
                Kids_BoycheckedListBox.SetItemChecked(2, true);
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    check = 0;

                    if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Boy" && ProductUC.itemList[i].category2 == "Accessories")
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (item.SubItems[2].Text == ProductUC.itemList[i].barcode)
                            {
                                ++check;
                            }
                        }
                        if (check == 0)
                        {
                            ListViewItem itemListView = new ListViewItem();
                            ItemsListView.SmallImageList = ProductUC.images;
                            itemListView.ImageIndex = i;
                            itemListView.SubItems.Add(ProductUC.itemList[i].name);
                            itemListView.SubItems.Add(ProductUC.itemList[i].barcode);
                            itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].quantity.ToString());
                            itemListView.SubItems.Add(ProductUC.itemList[i].color);
                            itemListView.SubItems.Add(ProductUC.itemList[i].material);

                            ItemsListView.Items.Add(itemListView);
                            ++record;
                        }
                    }

                    foreach (ListViewItem item in ItemsListView.Items)
                    {
                        if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                        {
                            if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Boy" && ProductUC.itemList[i].category2 != "Accessories")
                            {
                                item.Remove();

                                --record;
                            }

                        }
                    }
                }

                ItemRecordlbl.Text = "Total record = " + record;
                return;
            }
            else
            {
                if (secret1 == 2)
                {
                    for (int i = 0; i < ProductUC.itemList.Count; ++i)
                    {
                        foreach (ListViewItem item in ItemsListView.Items)
                        {
                            if (ProductUC.itemList[i].barcode == item.SubItems[2].Text)
                            {
                                if (ProductUC.itemList[i].category == "Kids" && ProductUC.itemList[i].category1 == "Boy" && ProductUC.itemList[i].category2 == "Accessories")
                                {
                                    item.Remove();

                                    --record;
                                }

                            }
                        }
                    }
                    ItemRecordlbl.Text = "Total record= " + record;
                }
            }
        }



        void ItemListView_columnWidthSet_NotHide()
        {
            ItemsListView.Columns[0].Width = 136;
            ItemsListView.Columns[1].Width = 192;
            ItemsListView.Columns[2].Width = 86;
            ItemsListView.Columns[3].Width = 91;
            ItemsListView.Columns[4].Width = 74;
            ItemsListView.Columns[5].Width = 88;
            ItemsListView.Columns[6].Width = 114;
        }

        void ItemListView_columnWidthSet_OneHide()
        {
            ItemsListView.Columns[0].Width = 140;
            ItemsListView.Columns[1].Width = 299;
            ItemsListView.Columns[2].Width = 113;
            ItemsListView.Columns[3].Width = 117;
            ItemsListView.Columns[4].Width = 82;
            ItemsListView.Columns[5].Width = 105;
            ItemsListView.Columns[6].Width = 151;
        }

        void ItemListView_columnWidthSet_Hide()
        {
            ItemsListView.Columns[0].Width = 145;
            ItemsListView.Columns[1].Width = 393;
            ItemsListView.Columns[2].Width = 127;
            ItemsListView.Columns[3].Width = 117;
            ItemsListView.Columns[4].Width = 82;
            ItemsListView.Columns[5].Width = 115;
            ItemsListView.Columns[6].Width = 263;
        }

        
        static int couninft=0;
        private void addToCartbtn_Click(object sender, EventArgs e)
        {
            int index = ItemsListView.SelectedIndices[0];
            //MessageBox.Show(index.ToString());

            //ListViewItem itemListView = new ListViewItem();
            //CartlistView.SmallImageList = ProductUC.images;
            //itemListView.ImageIndex = i;

            //++count;
            //itemListView.SubItems.Add(count.ToString());
            //itemListView.SubItems.Add(ItemsListView.Items[index].SubItems[1].Text.ToString());
            //itemListView.SubItems.Add(ItemsListView.Items[index].SubItems[3].Text.ToString());
            //itemListView.SubItems.Add(ItemsListView.Items[index].SubItems[5].Text.ToString());
            //itemListView.SubItems.Add(ItemsListView.Items[index].SubItems[6].Text.ToString());
            

            //CartlistView.Items.Add(itemListView);
            //++record;
            //ItemRecordlbl.Text = "Total record = " + record;


            for (int i = 0; i < ProductUC.itemList.Count; i++)
            {
                if (ItemsListView.Items[index].SubItems[2].Text.ToString() == ProductUC.itemList[i].barcode)
                {
                    ListViewItem itemListView = new ListViewItem();
                    CartlistView.SmallImageList = ProductUC.images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(ProductUC.itemList[i].name);
                    itemListView.SubItems.Add("RS" + ProductUC.itemList[i].price.ToString());
                    itemListView.SubItems.Add(ProductUC.itemList[i].color);
                    itemListView.SubItems.Add(ProductUC.itemList[i].material);

                    CartlistView.Items.Add(itemListView);
                    ++record;
                    ItemRecordlbl.Text = "Total record = " + record;
                    i = 0;
                    MessageBox.Show("Item successfully added to cart", "ADD TO CART", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }

        private void viewToCartbtn_Click(object sender, EventArgs e)
        {
            viewListpanel.BringToFront();
        }

        private void viewList_backbutton_Click(object sender, EventArgs e)
        {
            Itempanel.BringToFront();
        }

        private void clearCartbtn_Click(object sender, EventArgs e)
        {
           
            DialogResult res;
            res=MessageBox.Show("Are you sure you want to clear all Items on cart successfully clear?", "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        if(res==DialogResult.Yes)
        {
            CartlistView.Items.Clear();
            MessageBox.Show("All Items cleared successfully ", "Clear Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        }

        private void Infobackbtn_Click(object sender, EventArgs e)
        {
            Itempanel.BringToFront();
            ProductUC.images.ImageSize = new Size(150, 150);
        }

        private void generateslipbtn_Click(object sender, EventArgs e)
        {
            double price=0;
            generateListpanel.BringToFront();
            DateTime thisday=DateTime.Now;
            SlipDatelbl.Text = thisday.ToString();

            for (int j = 0; j < CartlistView.Items.Count; j++)
            {
                for (int i = 0; i < ProductUC.itemList.Count; i++)
                {
                    if (CartlistView.Items[j].SubItems[1].Text.ToString() == ProductUC.itemList[i].name)
                    {
                        --ProductUC.itemList[i].quantity;


                        //}

                        //for(int i = 0; i<CartlistView.Items.Count ; ++i)
                        //{

                        if (ProductUC.itemList[i].quantity >= 1)
                        {
                            double tempPrice = ProductUC.itemList[i].price;
                            //price = Convert.ToInt32(CartlistView.Items[j].SubItems[2].Text.Substring(2));
                            price +=tempPrice;
                        }
                        else
                            MessageBox.Show("The stock of item whose barcode is " + ProductUC.itemList[i].barcode + " is empty","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        break;
                    }
                }
            }

            SlipItemslbl.Text = CartlistView.Items.Count.ToString();
            SlipPricelbl.Text = price.ToString();
        }

        private void ItemInfobtn_Click(object sender, EventArgs e)
        {
            Infopanel.BringToFront();
            int index = ItemsListView.SelectedIndices[0];

            
            InfoPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            for (int i = 0; i < ProductUC.itemList.Count; i++)
            {
                if (ItemsListView.Items[index].SubItems[2].Text.ToString() == ProductUC.itemList[i].barcode)
                {
                   // ProductUC.images.ImageSize = new Size(250, 150);
                    InfoNamelbl.Text = ItemsListView.Items[index].SubItems[1].Text;
                    InfoPricelbl.Text = ItemsListView.Items[index].SubItems[3].Text;
                    InfoMaterialdatalbl.Text = ItemsListView.Items[index].SubItems[6].Text;
                    InfoStockdatalbl.Text = ItemsListView.Items[index].SubItems[4].Text;
                    InfoColordatalbl.Text = ItemsListView.Items[index].SubItems[5].Text;
                    //InfoPicBox.Image = ProductUC.images.Images[i];
                    int z = i + 1;
                    InfoPicBox.ImageLocation = @"D:\Pics\"+z+".jpg";
                    i = 0;
                    break;
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Itempanel.BringToFront();
        }

        private void ItemsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check = 0;
            for(int i=0;i<ItemsListView.Items.Count; i++)
            {
                if(ItemsListView.Items[i].Selected)
                {
                    check=58;
                    break;
                }
            }

            if(check==58)
            {
                addToCartbtn.Enabled = true;
                clearCartbtn.Enabled = true;
                viewToCartbtn.Enabled = true;
                ItemInfobtn.Enabled = true;
            }
            else
            {
                addToCartbtn.Enabled = false;
                clearCartbtn.Enabled = false;
                viewToCartbtn.Enabled = false;
                ItemInfobtn.Enabled = false;
            }
        }
    }
}
    


 
  

       
   


