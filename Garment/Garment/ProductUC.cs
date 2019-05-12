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
    public partial class ProductUC : UserControl
    {
        public static List<Items> itemList = new List<Items> ();
        public static ImageList images = new ImageList();
        public Items item ;
        public ProductUC()
        {
            InitializeComponent();
        }

        public void Data()
        {
            item = new Items();
            item.name = "Generation SWomen Yellow Voil Stripe Digital Printed 1 - Piece - Pzyruk Rug - Collection";
            item.price = 1598;
            item.quantity = 10;
            item.color = "Yellow";
            item.material = "Voil Stripe Digital Printed";
            item.barcode = "WPK0001";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Kurtas and Shalwar Kamiz";
            item.pic = "1";
            itemList.Add(item);

            item = new Items();
            item.name = "Danraj - The Big Collection 14 August - Embroidered Kurti For Women";
            item.price = 999;
            item.quantity = 10;
            item.color = "Multicolor";
            item.barcode = "WPK0002";
            item.material = "Cotton";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Kurtas and Shalwar Kamiz";
            item.pic = "2";
            itemList.Add(item);

            item = new Items();
            item.name = "TAGS TAGS PRINTED WESTERN STYLY LINEN KURTI FOR HER";
            item.price = 499;
            item.quantity = 10;
            item.color = "Multicolor";
            item.barcode = "WPK0003";
            item.material = "Linen";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Kurtas and Shalwar Kamiz";
            item.pic = "3";
            itemList.Add(item);

            item = new Items();
            item.name = "Generation Flo Blue Multi Douts Digital Printed - 1 Piece - Pineapple Express Collection";
            item.price = 1199;
            item.quantity = 10;
            item.color = "Blue";
            item.barcode = "WPK0004";
            item.material = "Multi Douts Digital Printed";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Kurtas and Shalwar Kamiz";
            item.pic = "4";
            itemList.Add(item);

            item = new Items();
            item.name = "Generation Basic Blue Slub Voil Rotary Printed 1 - Piece - Anglo Jap - Collection";
            item.price = 1149;
            item.quantity = 10;
            item.color = "Blue";
            item.barcode = "WPK0005";
            item.material = "Slub Voil Rotary Printed";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Kurtas and Shalwar Kamiz";
            item.pic = "5";
            itemList.Add(item);

            item = new Items();
            item.name = "Daraz Fashion 14 August Kurta with Green Tights For Her - Green";
            item.price = 699;
            item.quantity = 10;
            item.color = "White & Green";
            item.barcode = "WPK0006";
            item.material = "Cotton";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Kurtas and Shalwar Kamiz";
            item.pic = "6";
            itemList.Add(item);

            item = new Items();
            item.name = "BATIK Bluma red chiffon frock for women";
            item.price = 3592;
            item.quantity = 5;
            item.color = "Red";
            item.barcode = "WPF0001";
            item.material = "Chiffon";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Formal Wear";
            item.pic = "7";
            itemList.Add(item);

            item = new Items();
            item.name = "Bonanza Satrangi Brown Viscose Dress for Women";
            item.price = 3480;
            item.quantity = 3;
            item.color = "Brown";
            item.barcode = "WPF0002";
            item.material = "VISCOSE";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Formal Wear";
            item.pic = "8";
            itemList.Add(item);

            item = new Items();
            item.name = "Daraz Fashion Evening Dress With Pearl Detailing";
            item.price = 1999;
            item.quantity = 10;
            item.color = "Black";
            item.barcode = "WPF0003";
            item.material = "Chiffon,Crochet,Mixed,Silk";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Formal Wear";
            item.pic = "9";
            itemList.Add(item);

            item = new Items();
            item.name = "Daraz Fashion Evening Maxi Dress Blue With Beats";
            item.price = 2899;
            item.quantity = 6;
            item.color = "Blue";
            item.barcode = "WPF0004";
            item.material = "Chinese,Lace,Silk";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Formal Wear";
            item.pic = "10";
            itemList.Add(item);

            item = new Items();
            item.name = "Karma Pink Red & Multi Color Raw Silk Madhubala 2 Pcs Dress for Women - 9000292";
            item.price = 59500;
            item.quantity = 2;
            item.color = "Red";
            item.barcode = "WPF0005";
            item.material = "Raw Silk";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Formal Wear";
            item.pic = "11";
            itemList.Add(item);

            item = new Items();
            item.name = "Karma Pink Multi Color Katan Silk Noor Jahan 2 Pcs Dress for Women - 9000372";
            item.price = 55000;
            item.quantity = 4;
            item.color = "Multi Color";
            item.barcode = "WPF0006";
            item.material = "Katan Silk";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Formal Wear";
            item.pic = "12";
            itemList.Add(item);

            item = new Items();
            item.name = "Hijab Style Navy Blue Korean Nida A-Line Abaya";
            item.price = 2350;
            item.quantity = 7;
            item.color = "Navy Blue";
            item.barcode = "WPA0001";
            item.material = "Nida";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Abbayas and Hijabs";
            item.pic = "13";
            itemList.Add(item);

            item = new Items();
            item.name = "Hijab Style Grey Extra Wide Flare Nida Fabric Abaya";
            item.price = 3250;
            item.quantity = 7;
            item.color = "Soft Grey";
            item.barcode = "WPA0002";
            item.material = "Nida";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Abbayas and Hijabs";
            item.pic = "14";
            itemList.Add(item);

            item = new Items();
            item.name = "Marwa Hijab-un-Nisa Black Abaya Koren Fabric";
            item.price = 3299;
            item.quantity = 7;
            item.color = "Black";
            item.barcode = "WPA0003";
            item.material = "Febric";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Abbayas and Hijabs";
            item.pic = "15";
            itemList.Add(item);

            item = new Items();
            item.name = "Jilani Tailors Black Malai Georgette Abaya For Women ";
            item.price = 12500;
            item.quantity = 2;
            item.color = "Black";
            item.barcode = "WPA0004";
            item.material = "Korean Nida Silk Inner & Chiffon Georgette Upper";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Abbayas and Hijabs";
            item.pic = "16";
            itemList.Add(item);

            item = new Items();
            item.name = "Jilani Tailors Black Malai Georgette Abaya For Women ";
            item.price = 6500;
            item.quantity = 12;
            item.color = "Black";
            item.barcode = "WPA0005";
            item.material = "Black Malai Korean Georgette";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Abbayas and Hijabs";
            item.pic = "17";
            itemList.Add(item);

            item = new Items();
            item.name = "Daraz Fashion Lawn Ball Glitter Scarf";
            item.price = 349;
            item.quantity = 15;
            item.color = "Dark Grey";
            item.barcode = "WPD0001";
            item.material = "Lawn";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Dupattas and Shawls";
            item.pic = "18";
            itemList.Add(item);

            item = new Items();
            item.name = "FISH Black Velvet Shawl";
            item.price = 1250;
            item.quantity = 10;
            item.color = "Black";
            item.barcode = "WPD0002";
            item.material = "Velvet";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Dupattas and Shawls";
            item.pic = "19";
            itemList.Add(item);

            item = new Items();
            item.name = "Kashmina Brown Woolen Shawl";
            item.price = 1050;
            item.quantity = 10;
            item.color = "Brown";
            item.barcode = "WPD0003";
            item.material = "Woolen";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Dupattas and Shawls";
            item.pic = "20";
            itemList.Add(item);

            item = new Items();
            item.name = "Hacket Green Silk Hacket Scarf";
            item.price = 1390;
            item.quantity = 10;
            item.color = "Green";
            item.barcode = "WPD0004";
            item.material = "Silk";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Dupattas and Shawls";
            item.pic = "21";
            itemList.Add(item);

            item = new Items();
            item.name = "Hacket Green Silk Hacket Scarf";
            item.price = 175;
            item.quantity = 10;
            item.color = "White";
            item.barcode = "WPD0005";
            item.material = "Cotton";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Dupattas and Shawls";
            item.pic = "22";
            itemList.Add(item);

            item = new Items();
            item.name = "FISH White Cotton Shalwar For Women";
            item.price = 1055;
            item.quantity = 5;
            item.color = "White";
            item.barcode = "WPP0001";
            item.material = "Cotton";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Pants and Plazzoes";
            item.pic = "23";
            itemList.Add(item);

            item = new Items();
            item.name = "Gem & Lib Black Candy Ball Embroidery Cigrate Pant";
            item.price = 850;
            item.quantity = 1;
            item.color = "Black";
            item.barcode = "WPP0002";
            item.material = "Cotton";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Pants and Plazzoes";
            item.pic = "24";
            itemList.Add(item);

            item = new Items();
            item.name = "The Warehouse abstract art jogger pant";
            item.price = 2899;
            item.quantity = 1;
            item.color = "Multicolor";
            item.barcode = "WPP0003";
            item.material = "Fleece";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Pants and Plazzoes";
            item.pic = "25";
            itemList.Add(item);

            item = new Items();
            item.name = "Blossom Black Flarred Bell Bottoms";
            item.price = 350;
            item.quantity = 5;
            item.color = "Black";
            item.barcode = "WPP0004";
            item.material = "Fleece";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Pants and Plazzoes";
            item.pic = "26";
            itemList.Add(item);

            item = new Items();
            item.name = "Contessa White Cotton Lycra Tulip Shalwar for Women";
            item.price = 240;
            item.quantity = 5;
            item.color = "White";
            item.barcode = "WPP0005";
            item.material = "Cotton Lycra";
            item.category = "Women";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Pants and Plazzoes";
            item.pic = "27";
            itemList.Add(item);

            item = new Items();
            item.name = "Generation Pink Strip Rotary Printed Stitched 1 - Piece - Tibetan Pleatau";
            item.price = 2718;
            item.quantity = 5;
            item.color = "Pink";
            item.barcode = "WWT0001";
            item.material = "Strip Cotton Rotary Printed";
            item.category = "Women";
            item.category1 = "Westren Clothing";
            item.category2 = "Tops and Shirts";
            item.pic = "28";
            itemList.Add(item);

            item = new Items();
            item.name = "Buysense Multi color panel Western style Tunic For Women";
            item.price = 999;
            item.quantity = 5;
            item.color = "Multicolor";
            item.barcode = "WWT0002";
            item.material = "Boski";
            item.category = "Women";
            item.category1 = "Westren Clothing";
            item.category2 = "Tops and Shirts";
            item.pic = "29";
            itemList.Add(item);

            item = new Items();
            item.name = "Danraj - The Big Collection Maroon Boksi Shirt for Women";
            item.price = 799;
            item.quantity = 10;
            item.color = "Maroon";
            item.barcode = "WWT0003";
            item.material = "Boski";
            item.category = "Women";
            item.category1 = "Westren Clothing";
            item.category2 = "Tops and Shirts";
            item.pic = "30";
            itemList.Add(item);

            item = new Items();
            item.name = "star garnet Red Chiffon Tunic For Women";
            item.price = 599;
            item.quantity = 5;
            item.color = "Red";
            item.barcode = "WWT0004";
            item.material = "Chiffon";
            item.category = "Women";
            item.category1 = "Westren Clothing";
            item.category2 = "Tops and Shirts";
            item.pic = "31";
            itemList.Add(item);

            item = new Items();
            item.name = "Zewraat Red Embroidered Shirt For Women";
            item.price = 1199;
            item.quantity = 5;
            item.color = "Red";
            item.barcode = "WWT0005";
            item.material = "Boski";
            item.category = "Women";
            item.category1 = "Westren Clothing";
            item.category2 = "Tops and Shirts";
            item.pic = "32";
            itemList.Add(item);

            item = new Items();
            item.name = "Aeys 14th August Green Western Chand Sitara Printed Tunic For Women";
            item.price = 699;
            item.quantity = 15;
            item.color = "Green";
            item.barcode = "WWT0006";
            item.material = "Boski Linen";
            item.category = "Women";
            item.category1 = "Westren Clothing";
            item.category2 = "Tops and Shirts";
            item.pic = "33";
            itemList.Add(item);

            item = new Items();
            item.name = "Daraz Fashion Red Cross Cold Shoulder T-Shirt For Women";
            item.price = 499;
            item.quantity = 15;
            item.color = "Red";
            item.barcode = "WWTS0001";
            item.material = "Cotton";
            item.category = "Women";
            item.category1 = "Westren Clothing";
            item.category2 = "T-Shirts";
            item.pic = "34";
            itemList.Add(item);

            item = new Items();
            item.name = "Daraz Fashion Heather Grey Cold Shoulder Long Sleeve T-Shirt For Women";
            item.price = 399;
            item.quantity = 15;
            item.color = "Heather Grey";
            item.barcode = "WWTS0002";
            item.material = "Cotton";
            item.category = "Women";
            item.category1 = "Westren Clothing";
            item.category2 = "T-Shirts";
            item.pic = "35";
            itemList.Add(item);

            item = new Items();
            item.name = "Daraz Fashion Imran Khan Face Green T-Shirt For Women";
            item.price = 275;
            item.quantity = 10;
            item.color = "Green";
            item.barcode = "WWTS0003";
            item.material = "Cotton";
            item.category = "Women";
            item.category1 = "Westren Clothing";
            item.category2 = "T-Shirts";
            item.pic = "36";
            itemList.Add(item);

            item = new Items();
            item.name = "A&G White Cotton I Love Pakistan Printed T-Shirt for Women";
            item.price = 299;
            item.quantity = 5;
            item.color = "White";
            item.barcode = "WWTS0004";
            item.material = "Cotton";
            item.category = "Women";
            item.category1 = "Westren Clothing";
            item.category2 = "T-Shirts";
            item.pic = "37";
            itemList.Add(item);

            item = new Items();
            item.name = "A&G Green Cotton 14th August Flag Printed T-Shirt for Women";
            item.price = 299;
            item.quantity = 15;
            item.color = "Green";
            item.barcode = "WWTS0005";
            item.material = "Cotton";
            item.category = "Women";
            item.category1 = "Westren Clothing";
            item.category2 = "T-Shirts";
            item.pic = "38";
            itemList.Add(item);

            item = new Items();
            item.name = "The Aster Black Cotton Plain T-Shirts For Women";
            item.price = 499;
            item.quantity = 15;
            item.color = "Black";
            item.barcode = "WWTS0006";
            item.material = "Cotton";
            item.category = "Women";
            item.category1 = "Westren Clothing";
            item.category2 = "T-Shirts";
            item.pic = "39";
            itemList.Add(item);

            item = new Items();
            item.name = "Origins Purple Slub Legging for Women";
            item.price = 999;
            item.quantity = 15;
            item.color = "Purple";
            item.barcode = "WWB0001";
            item.material = "Slub";
            item.category = "Women";
            item.category1 = "Westren Clothing";
            item.category2 = "Bottoms and Tights";
            item.pic = "40";
            itemList.Add(item);

            item = new Items();
            item.name = "Bhimani's Vogue Multicolor Cotton Abstract Design Tights For Women";
            item.price = 499;
            item.quantity = 5;
            item.color = "Multicolor";
            item.barcode = "WWB0002";
            item.material = "Cotton";
            item.category = "Women";
            item.category1 = "Westren Clothing";
            item.category2 = "Bottoms and Tights";
            item.pic = "41";
            itemList.Add(item);

            item = new Items();
            item.name = "Katy & Cross Blue Cotton Tights";
            item.price = 347;
            item.quantity = 15;
            item.color = "Blue";
            item.barcode = "WWB0003";
            item.material = "Jersey";
            item.category = "Women";
            item.category1 = "Westren Clothing";
            item.category2 = "Bottoms and Tights";
            item.pic = "42";
            itemList.Add(item);

            item = new Items();
            item.name = "Aybeez Skin Cotton Tights for Women";
            item.price = 399;
            item.quantity = 5;
            item.color = "Skin";
            item.barcode = "WWB0004";
            item.material = "Cotton";
            item.category = "Women";
            item.category1 = "Westren Clothing";
            item.category2 = "Bottoms and Tights";
            item.pic = "43";
            itemList.Add(item);

            item = new Items();
            item.name = "Panache Ladies Navy Blue Faded Jeans ";
            item.price = 999;
            item.quantity = 5;
            item.color = "Navy Blue";
            item.barcode = "WWJ0001";
            item.material = "Other";
            item.category = "Women";
            item.category1 = "Westren Clothing";
            item.category2 = "Jeans";
            item.pic = "44";
            itemList.Add(item);

            item = new Items();
            item.name = "SA Bazaar Blue Skinny Fit Mid-Rise Clean Look Stretchable Jeans";
            item.price = 1050;
            item.quantity = 5;
            item.color = "Blue";
            item.barcode = "WWJ0002";
            item.material = "Cotton";
            item.category = "Women";
            item.category1 = "Westren Clothing";
            item.category2 = "Jeans";
            item.pic = "45";
            itemList.Add(item);

            item = new Items();
            item.name = "IGNITE Medium Pink Basic Stretch Pants For Women";
            item.price = 799;
            item.quantity = 15;
            item.color = "Medium Pink";
            item.barcode = "WWJ0003";
            item.material = "Cotton Stretch";
            item.category = "Women";
            item.category1 = "Westren Clothing";
            item.category2 = "Jeans";
            item.pic = "46";
            itemList.Add(item);

            item = new Items();
            item.name = "Daraz Fashion Medium Black Ripped Slim Fit Jeans For Women";
            item.price = 999;
            item.quantity = 5;
            item.color = "Black";
            item.barcode = "WWJ0004";
            item.material = "Denim";
            item.category = "Women";
            item.category1 = "Westren Clothing";
            item.category2 = "Jeans";
            item.pic = "47";
            itemList.Add(item);

            item = new Items();
            item.name = "Koy Blue Stainless Steel Sunglasses For Women";
            item.price = 1800;
            item.quantity = 15;
            item.color = "Blue";
            item.barcode = "WAE0001";
            item.material = "Stainless Steel";
            item.category = "Women";
            item.category1 = "Accessories";
            item.category2 = "Eye Wear";
            item.pic = "48";
            itemList.Add(item);

            item = new Items();
            item.name = "Asporea AP-Women Blue Flash Sunglasses";
            item.price = 1350;
            item.quantity = 8;
            item.color = "Blue";
            item.barcode = "WAE0002";
            item.material = "Plastic";
            item.category = "Women";
            item.category1 = "Accessories";
            item.category2 = "Eye Wear";
            item.pic = "49";
            itemList.Add(item);

            item = new Items();
            item.name = "Suchi Products Black Women Acetate Frame Grey With Gradient Polarized Lens";
            item.price = 20999;
            item.quantity = 2;
            item.color = "Black";
            item.barcode = "WAE0003";
            item.material = "Acetate";
            item.category = "Women";
            item.category1 = "Accessories";
            item.category2 = "Eye Wear";
            item.pic = "50";
            itemList.Add(item);

            item = new Items();
            item.name = "Ragazzo Black Single Bridge Sunglasses Unisex";
            item.price = 729;
            item.quantity = 12;
            item.color = "Black";
            item.barcode = "WAE0004";
            item.material = "Plastic and Metal";
            item.category = "Women";
            item.category1 = "Accessories";
            item.category2 = "Eye Wear";
            item.pic = "51";
            itemList.Add(item);

            item = new Items();
            item.name = "Ragazzo Golden Metal Frame With graded Lens Sunglasses Unisex";
            item.price = 899;
            item.quantity = 12;
            item.color = "Golden and Brown";
            item.barcode = "WAE0005";
            item.material = "Plastic and Metal";
            item.category = "Women";
            item.category1 = "Accessories";
            item.category2 = "Eye Wear";
            item.pic = "52";
            itemList.Add(item);

            item = new Items();
            item.name = "Etihad Etihad Synthetic Leather Women Fashion Backpack";
            item.price = 1999;
            item.quantity = 6;
            item.color = "Tan";
            item.barcode = "WAB0001";
            item.material = "Artificial Leather";
            item.category = "Women";
            item.category1 = "Accessories";
            item.category2 = "Bags";
            item.pic = "53";
            itemList.Add(item);

            item = new Items();
            item.name = "Milano Mall Grey Stylish Cross Body Hand Bag";
            item.price = 649;
            item.quantity = 16;
            item.color = "Grey";
            item.barcode = "WAB0002";
            item.material = "Leather";
            item.category = "Women";
            item.category1 = "Accessories";
            item.category2 = "Bags";
            item.pic = "54";
            itemList.Add(item);

            item = new Items();
            item.name = "Beautisfy Cute Stuffed Girls College, Uni And School Bags ";
            item.price = 1038;
            item.quantity = 10;
            item.color = "Multicolor";
            item.barcode = "WAB0003";
            item.material = "Other";
            item.category = "Women";
            item.category1 = "Accessories";
            item.category2 = "Bags";
            item.pic = "55";
            itemList.Add(item);

            item = new Items();
            item.name = "Etihad Personalized England Style Canvas Backpack Stylish College Bag for Girls";
            item.price = 1299;
            item.quantity = 10;
            item.color = "Multicolor";
            item.barcode = "WAB0004";
            item.material = "Canvas";
            item.category = "Women";
            item.category1 = "Accessories";
            item.category2 = "Bags";
            item.pic = "56";
            itemList.Add(item);

            item = new Items();
            item.name = "Prime Black Leather Hand Bag For Women";
            item.price = 1499;
            item.quantity = 10;
            item.color = "Black";
            item.barcode = "WAB0005";
            item.material = "Leather";
            item.category = "Women";
            item.category1 = "Accessories";
            item.category2 = "Bags";
            item.pic = "57";
            itemList.Add(item);

            item = new Items();
            item.name = "Dealz On Hai Black Warm Mufler Scarf";
            item.price = 699;
            item.quantity = 10;
            item.color = "Black";
            item.barcode = "WAS0001";
            item.material = "Cotton";
            item.category = "Women";
            item.category1 = "Scarves and Mufflers";
            item.category2 = "Bags";
            item.pic = "58";
            itemList.Add(item);

            item = new Items();
            item.name = "Daraz Fashion Grey Latest New Luxury Fashion Pearl Scarf 2018";
            item.price = 699;
            item.quantity = 10;
            item.color = "Light Grey";
            item.barcode = "WAS0002";
            item.material = "Cotton";
            item.category = "Women";
            item.category1 = "Accessories";
            item.category2 = "Scarves and Mufflers";
            item.pic = "59";
            itemList.Add(item);

            item = new Items();
            item.name = "Daraz Fashion Pink Latest New Luxury Silk Chiffon Embroidered Scarf 2018";
            item.price = 699;
            item.quantity = 10;
            item.color = "Pink";
            item.barcode = "WAS0003";
            item.material = "Silk Chiffon";
            item.category = "Women";
            item.category1 = "Accessories";
            item.category2 = "Scarves and Mufflers";
            item.pic = "60";
            itemList.Add(item);

            item = new Items();
            item.name = "HOMEnMORE Stole Scarf Hijab Abaya Royal Blue 3ft High Quality Imported";
            item.price = 1490;
            item.quantity = 4;
            item.color = "Blue";
            item.barcode = "WAS0004";
            item.material = "Polyster";
            item.category = "Women";
            item.category1 = "Accessories";
            item.category2 = "Scarves and Mufflers";
            item.pic = "61";
            itemList.Add(item);

            item = new Items();
            item.name = "Daraz Fashion Mustard/Golden Latest New Luxury Embroidered Silk Bend Turkish Scarf 2018";
            item.price = 1050;
            item.quantity = 7;
            item.color = "Mustard/Golden";
            item.barcode = "WAS0005";
            item.material = "Silk Blend";
            item.category = "Women";
            item.category1 = "Accessories";
            item.category2 = "Scarves and Mufflers";
            item.pic = "62";
            itemList.Add(item);

            item = new Items();
            item.name = "The Marshall Red Bottle of Love Pendant Necklace for Women";
            item.price = 199;
            item.quantity = 7;
            item.color = "Red";
            item.barcode = "WAJ0001";
            item.material = "Alloy";
            item.category = "Women";
            item.category1 = "Accessories";
            item.category2 = "Jwellery";
            item.pic = "63";
            itemList.Add(item);

            item = new Items();
            item.name = "The Marshall Golden ECG Pendant Necklace for Women";
            item.price = 199;
            item.quantity = 7;
            item.color = "Golden";
            item.barcode = "WAJ0002";
            item.material = "Alloy";
            item.category = "Women";
            item.category1 = "Accessories";
            item.category2 = "Jwellery";
            item.pic = "64";
            itemList.Add(item);

            item = new Items();
            item.name = "Silverstone Golden Zircon Studded Anklet For Women";
            item.price = 100000;
            item.quantity = 1;
            item.color = "Multicolor";
            item.barcode = "WAJ0003";
            item.material = "Other";
            item.category = "Women";
            item.category1 = "Accessories";
            item.category2 = "Jwellery";
            item.pic = "65";
            itemList.Add(item);

            item = new Items();
            item.name = "SK Golden - Arrow Anklet Chain Jewelry For Women";
            item.price = 599;
            item.quantity = 13;
            item.color = "Golden";
            item.barcode = "WAJ0004";
            item.material = "Alloy";
            item.category = "Women";
            item.category1 = "Accessories";
            item.category2 = "Jwellery";
            item.pic = "66";
            itemList.Add(item);

            item = new Items();
            item.name = "Moncler Brown Leather Long Coat For Women";
            item.price = 3999;
            item.quantity = 3;
            item.color = "Brown";
            item.barcode = "WWJA0001";
            item.material = "Faux Leather";
            item.category = "Women";
            item.category1 = "Winter Wear";
            item.category2 = "Jackets and Coats";
            item.pic = "67";
            itemList.Add(item);

            item = new Items();
            item.name = "Prime Ladies Parachute Jacket Women Jacket";
            item.price = 1999;
            item.quantity = 7;
            item.color = "Black";
            item.barcode = "WWJA0002";
            item.material = "Parachute";
            item.category = "Women";
            item.category1 = "Winter Wear";
            item.category2 = "Jackets and Coats";
            item.pic = "68";
            itemList.Add(item);

            item = new Items();
            item.name = "A&G Black Fleece Long Coat For Women";
            item.price = 899;
            item.quantity = 7;
            item.color = "Black";
            item.barcode = "WWJA0003";
            item.material = "Fleece";
            item.category = "Women";
            item.category1 = "Winter Wear";
            item.category2 = "Jackets and Coats";
            item.pic = "69";
            itemList.Add(item);

            item = new Items();
            item.name = "Fashion Factory Navy Blue Fleece Pocket Coat";
            item.price = 999;
            item.quantity = 10;
            item.color = "Navy Blue";
            item.barcode = "WWJA0004";
            item.material = "Fleece";
            item.category = "Women";
            item.category1 = "Winter Wear";
            item.category2 = "Jackets and Coats";
            item.pic = "70";
            itemList.Add(item);

            item = new Items();
            item.name = "Moncler Orange Leather Jacket For Women";
            item.price = 2999;
            item.quantity = 10;
            item.color = "Orange";
            item.barcode = "WWJA0005";
            item.material = "Faux Leather";
            item.category = "Women";
            item.category1 = "Winter Wear";
            item.category2 = "Jackets and Coats";
            item.pic = "71";
            itemList.Add(item);

            item = new Items();
            item.name = "A&G A&G Black Fleece Hoodie For Women";
            item.price = 699;
            item.quantity = 10;
            item.color = "Black";
            item.barcode = "WWH0001";
            item.material = "Fleece";
            item.category = "Women";
            item.category1 = "Winter Wear";
            item.category2 = "Hoodies";
            item.pic = "72";
            itemList.Add(item);

            item = new Items();
            item.name = "Essentials Charcoal Grey Fleece Zipper Hoodie For Women";
            item.price = 699;
            item.quantity = 10;
            item.color = "Charcoal Grey";
            item.barcode = "WWH0002";
            item.material = "Fleece";
            item.category = "Women";
            item.category1 = "Winter Wear";
            item.category2 = "Hoodies";
            item.pic = "73";
            itemList.Add(item);

            item = new Items();
            item.name = "Contessa Stylish Zipper Hoodie For Women";
            item.price = 690;
            item.quantity = 10;
            item.color = "Multicolor";
            item.barcode = "WWH0003";
            item.material = "Fleece";
            item.category = "Women";
            item.category1 = "Winter Wear";
            item.category2 = "Hoodies";
            item.pic = "74";
            itemList.Add(item);

            item = new Items();
            item.name = "Mart89 Women Navy Blue Printed Hoodies";
            item.price = 584;
            item.quantity = 4;
            item.color = "Navy Blue";
            item.barcode = "WWH0004";
            item.material = "Fleece";
            item.category = "Women";
            item.category1 = "Winter Wear";
            item.category2 = "Hoodies";
            item.pic = "75";
            itemList.Add(item);

            item = new Items();
            item.name = "Fashion Café Grey Cotton Hoodie For Women";
            item.price = 349;
            item.quantity = 8;
            item.color = "Light Grey";
            item.barcode = "WWH0005";
            item.material = "Cotton";
            item.category = "Women";
            item.category1 = "Winter Wear";
            item.category2 = "Hoodies";
            item.pic = "76";
            itemList.Add(item);

            item = new Items();
            item.name = "The Marshall Navy Blue Cut Glass Crystal Analog Watch for Women";
            item.price = 699;
            item.quantity = 8;
            item.color = "Navy Blue";
            item.barcode = "WWA0001";
            item.material = "Alloy";
            item.category = "Women";
            item.category1 = "Watches";
            item.category2 = "Analog";
            item.pic = "77";
            itemList.Add(item);

            item = new Items();
            item.name = "Shopping Mania Black Swiss Made Ladies Watch";
            item.price = 1499;
            item.quantity = 8;
            item.color = "Black";
            item.barcode = "WWA0002";
            item.material = "Stainless Steel";
            item.category = "Women";
            item.category1 = "Watches";
            item.category2 = "Analog";
            item.pic = "78";
            itemList.Add(item);

            item = new Items();
            item.name = "Shopping Mania Black Swiss Made Ladies Watch";
            item.price = 29300;
            item.quantity = 2;
            item.color = "Pink";
            item.barcode = "WWA0003";
            item.material = "Leather";
            item.category = "Women";
            item.category1 = "Watches";
            item.category2 = "Analog";
            item.pic = "79";
            itemList.Add(item);

            item = new Items();
            item.name = "Michael Kors White Stainless Steel Analog Watch for Women ";
            item.price = 35800;
            item.quantity = 2;
            item.color = "White";
            item.barcode = "WWA0004";
            item.material = "Stainless Steel";
            item.category = "Women";
            item.category1 = "Watches";
            item.category2 = "Analog";
            item.pic = "80";
            itemList.Add(item);

            item = new Items();
            item.name = "Super Fit LED Sports Watch - Limited Edition";
            item.price = 99;
            item.quantity = 12;
            item.color = "Pink";
            item.barcode = "WWS0001";
            item.material = "Rubber, Steel, Plastic & Silicon";
            item.category = "Women";
            item.category1 = "Watches";
            item.category2 = "Smart";
            item.pic = "81";
            itemList.Add(item);

            item = new Items();
            item.name = "Getiit Pulse II Smart Bracelet (4th Generation)";
            item.price = 4250;
            item.quantity = 6;
            item.color = "Black";
            item.barcode = "WWS0002";
            item.material = "Silica";
            item.category = "Women";
            item.category1 = "Watches";
            item.category2 = "Smart";
            item.pic = "82";
            itemList.Add(item);

            item = new Items();
            item.name = "Arbiapk GT08 - GSM & Bluetooth Smart Watch";
            item.price = 2160;
            item.quantity = 6;
            item.color = "Black";
            item.barcode = "WWS0003";
            item.material = "Other";
            item.category = "Women";
            item.category1 = "Watches";
            item.category2 = "Smart";
            item.pic = "83";
            itemList.Add(item);

            item = new Items();
            item.name = "Timex Tw00sos04t - Blink Rose Gold Smart Band Watch ";
            item.price = 11357;
            item.quantity = 6;
            item.color = "Rose Golden";
            item.barcode = "WWS0004";
            item.material = "Metal";
            item.category = "Women";
            item.category1 = "Watches";
            item.category2 = "Smart";
            item.pic = "84";
            itemList.Add(item);

            item = new Items();
            item.name = "SKMEI SK1251- Resin - Unisex Digital Sports Watch";
            item.price = 1299;
            item.quantity = 6;
            item.color = "Black";
            item.barcode = "WWD0001";
            item.material = "Plastic";
            item.category = "Women";
            item.category1 = "Watches";
            item.category2 = "Digital";
            item.pic = "85";
            itemList.Add(item);

            item = new Items();
            item.name = "Rubian Diamond LED Watch For Ladies";
            item.price = 399;
            item.quantity = 16;
            item.color = "Pink";
            item.barcode = "WWD0002";
            item.material = "Silicon";
            item.category = "Women";
            item.category1 = "Watches";
            item.category2 = "Digital";
            item.pic = "86";
            itemList.Add(item);

            item = new Items();
            item.name = "A N Electronics Independence day Special watch";
            item.price = 299;
            item.quantity = 6;
            item.color = "Green";
            item.barcode = "WWD0003";
            item.material = "Rubber";
            item.category = "Women";
            item.category1 = "Watches";
            item.category2 = "Digital";
            item.pic = "87";
            itemList.Add(item);

            item = new Items();
            item.name = "Daraz Fashion Black Leather Watch For Women";
            item.price = 999;
            item.quantity = 6;
            item.color = "Black";
            item.barcode = "WWD0004";
            item.material = "Metal";
            item.category = "Women";
            item.category1 = "Watches";
            item.category2 = "Digital";
            item.pic = "88";
            itemList.Add(item);

            item = new Items();
            item.name = "Daraz Fashion Silver Stainless Steel Chronograph Watch ";
            item.price = 499;
            item.quantity = 6;
            item.color = "Silver";
            item.barcode = "WWC0001";
            item.material = "Stainless steel";
            item.category = "Women";
            item.category1 = "Watches";
            item.category2 = "Cornograph";
            item.pic = "89";
            itemList.Add(item);

            item = new Items();
            item.name = "Fossil Black Leather Chronograph Watch For Women";
            item.price = 16300;
            item.quantity = 3;
            item.color = "Black";
            item.barcode = "WWC0002";
            item.material = "Leather";
            item.category = "Women";
            item.category1 = "Watches";
            item.category2 = "Cornograph";
            item.pic = "90";
            itemList.Add(item);

            item = new Items();
            item.name = "Emporio Armani Rose Chronograph Ladies Watch";
            item.price = 51400;
            item.quantity = 1;
            item.color = "Rose Gold";
            item.barcode = "WWC0003";
            item.material = "Metal";
            item.category = "Women";
            item.category1 = "Watches";
            item.category2 = "Cornograph";
            item.pic = "91";
            itemList.Add(item);

            item = new Items();
            item.name = "Fashionholic Online White Sandal for Women";
            item.price = 1104;
            item.quantity = 10;
            item.color = "White";
            item.barcode = "WSS0001";
            item.material = "Leather";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Sandals";
            item.pic = "92";
            itemList.Add(item);

            item = new Items();
            item.name = "Fashionholic Online Black Heeled Sandals for Women";
            item.price = 1104;
            item.quantity = 5;
            item.color = "Black";
            item.barcode = "WSS0002";
            item.material = "Leather";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Sandals";
            item.pic = "93";
            itemList.Add(item);

            item = new Items();
            item.name = "Maya Traders Chocolate Brown Imported Italian Design Fancy Sandal for Women - B03";
            item.price = 590;
            item.quantity = 10;
            item.color = "Choclate Brown";
            item.barcode = "WSS0003";
            item.material = "Rubber";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Sandals";
            item.pic = "94";
            itemList.Add(item);

            item = new Items();
            item.name = "Mojari Peach Sheesha Peshawari For Women SS-2200";
            item.price = 1319;
            item.quantity = 10;
            item.color = "Peach";
            item.barcode = "WSS0004";
            item.material = "Synthetic";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Sandals";
            item.pic = "95";
            itemList.Add(item);

            item = new Items();
            item.name = "Fashionholic Online White Branded Slipper with Gold Look for Women";
            item.price = 1274;
            item.quantity = 7;
            item.color = "White";
            item.barcode = "WSC0001";
            item.material = "Leather";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Slippers";
            item.pic = "96";
            itemList.Add(item);

            item = new Items();
            item.name = "Aeys Skin Massager Thailand Imported Slipper For Women";
            item.price = 699;
            item.quantity = 17;
            item.color = "Skin";
            item.barcode = "WSC0002";
            item.material = "Rubber";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Slippers";
            item.pic = "97";
            itemList.Add(item);

            item = new Items();
            item.name = "Shoe Rack Pink Imported Slipper For Women";
            item.price = 599;
            item.quantity = 7;
            item.color = "Pink";
            item.barcode = "WSC0003";
            item.material = "Rubber";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Slippers";
            item.pic = "98";
            itemList.Add(item);

            item = new Items();
            item.name = "Shoe Rack Blue Imported Slipper For Women";
            item.price = 599;
            item.quantity = 12;
            item.color = "Blue";
            item.barcode = "WSC0004";
            item.material = "Rubber";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Slippers";
            item.pic = "99";
            itemList.Add(item);

            item = new Items();
            item.name = "Mojari Maroon Velvet Kundun Leather Khussa for Women";
            item.price = 1319;
            item.quantity = 9;
            item.color = "Maroon";
            item.barcode = "WSK0001";
            item.material = "Leather";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Khussa";
            item.pic = "100";
            itemList.Add(item);

            item = new Items();
            item.name = "Mojari Maroon Leather Plain Khussa For Women SS-184";
            item.price = 1199;
            item.quantity = 12;
            item.color = "Mojari";
            item.barcode = "WSK0002";
            item.material = "Leather";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Khussa";
            item.pic = "101";
            itemList.Add(item);

            item = new Items();
            item.name = "Mojari Camel Leather Cut Work Peep Toe Khussa For Women SS-600";
            item.price = 1319;
            item.quantity = 10;
            item.color = "Camel";
            item.barcode = "WSK0003";
            item.material = "Leather";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Khussa";
            item.pic = "102";
            itemList.Add(item);

            item = new Items();
            item.name = "ANSHA MART Ansha Marts Kundan Khussa Collection For Women";
            item.price = 2899;
            item.quantity = 10;
            item.color = "Multicolor";
            item.barcode = "WSK0004";
            item.material = "Leather, Beats";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Khussa";
            item.pic = "103";
            itemList.Add(item);

            item = new Items();
            item.name = "Avis Multicolor Synthetic Shoes For Women";
            item.price = 2700;
            item.quantity = 10;
            item.color = "Multicolor";
            item.barcode = "WSH0001";
            item.material = "Synthetic";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Heels";
            item.pic = "104";
            itemList.Add(item);

            item = new Items();
            item.name = "Hadi's Her's Pink - Heel - Sheet";
            item.price = 3700;
            item.quantity = 3;
            item.color = "Pink";
            item.barcode = "WSH0002";
            item.material = "Cotton Leather";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Heels";
            item.pic = "105";
            itemList.Add(item);

            item = new Items();
            item.name = "Hadi's Her's Maroon- Heel - Suede Leather";
            item.price = 3700;
            item.quantity = 5;
            item.color = "Maroon";
            item.barcode = "WSH0003";
            item.material = "Suede Leather";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Heels";
            item.pic = "106";
            itemList.Add(item);

            item = new Items();
            item.name = "Avis Brown Synthetic Shoes For Women";
            item.price = 2310;
            item.quantity = 5;
            item.color = "Brown";
            item.barcode = "WSH0004";
            item.material = "Synthetic";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Heels";
            item.pic = "107";
            itemList.Add(item);

            item = new Items();
            item.name = "Avis Green Synthetic Shoes For Women";
            item.price = 2610;
            item.quantity = 5;
            item.color = "Green";
            item.barcode = "WSH0005";
            item.material = "Synthetic";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Heels";
            item.pic = "108";
            itemList.Add(item);

            item = new Items();
            item.name = "Maya Traders Maroon Canvas Slip On Rubber Dye Toms For Women ";
            item.price = 790;
            item.quantity = 15;
            item.color = "Maroon";
            item.barcode = "WSP0001";
            item.material = "Canvas Rubber Dye";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Pumps";
            item.pic = "109";
            itemList.Add(item);

            item = new Items();
            item.name = "Chase Value Centre Black Artificial Leather Women's Pumps CVC-23A";
            item.price = 599;
            item.quantity = 12;
            item.color = "Black";
            item.barcode = "WSP0002";
            item.material = "Artificial Leather";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Pumps";
            item.pic = "110";
            itemList.Add(item);

            item = new Items();
            item.name = "Chase Value Centre Camel Artificial Leather Women's Pumps 071-304";
            item.price = 899;
            item.quantity = 5;
            item.color = "Camel";
            item.barcode = "WSP0003";
            item.material = "Artificial Leather";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Pumps";
            item.pic = "111";
            itemList.Add(item);

            item = new Items();
            item.name = "Milli mega store Imported Shoes For Ladies Brooch Material-Ms-0505-Red-41";
            item.price = 2500;
            item.quantity = 3;
            item.color = "Red";
            item.barcode = "WSP0004";
            item.material = "Brooch";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Pumps";
            item.pic = "112";
            itemList.Add(item);

            item = new Items();
            item.name = "Bata Royal Blue Casual Running Shoes for Women";
            item.price = 1999;
            item.quantity = 13;
            item.color = "Royal Blue";
            item.barcode = "WSSN0001";
            item.material = "Synthetic";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Sneakers";
            item.pic = "113";
            itemList.Add(item);

            item = new Items();
            item.name = "Meerbound Casual Sneaker For Women";
            item.price = 1699;
            item.quantity = 5;
            item.color = "Multicolor";
            item.barcode = "WSSN0002";
            item.material = "Synthetic";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Sneakers";
            item.pic = "114";
            itemList.Add(item);

            item = new Items();
            item.name = "Makkah Mini Mart Cream Sneaker For Women";
            item.price = 1799;
            item.quantity = 5;
            item.color = "Cream";
            item.barcode = "WSSN0003";
            item.material = "Valvet";
            item.category = "Women";
            item.category1 = "Shoes";
            item.category2 = "Sneakers";
            item.pic = "115";
            itemList.Add(item);

            item = new Items();
            item.name = "A&J 10 Messi Printed T Shirt For Men";
            item.price = 399;
            item.quantity = 5;
            item.color = "Navy Blue";
            item.barcode = "MWT0001";
            item.material = "Cotton";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "T-Shirts";
            item.pic = "116";
            itemList.Add(item);

            item = new Items();
            item.name = "Tees Bank Karachi Printed T-Shirt For Men - Half Sleeves - Charcoal";
            item.price = 330;
            item.quantity = 5;
            item.color = "Charcol";
            item.barcode = "MWT0002";
            item.material = "Cotton";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "T-Shirts";
            item.pic = "117";
            itemList.Add(item);

            item = new Items();
            item.name = "Aybeez Pack of 3 - Multicolor Lining T-Shirts for Men";
            item.price = 799;
            item.quantity = 3;
            item.color = "Multicolor";
            item.barcode = "MWT0003";
            item.material = "Cotton";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "T-Shirts";
            item.pic = "118";
            itemList.Add(item);

            item = new Items();
            item.name = "Mardaz Blue Cotton Printed Tshirt For Men";
            item.price = 299;
            item.quantity = 13;
            item.color = "Blue";
            item.barcode = "MWT0004";
            item.material = "Cotton";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "T-Shirts";
            item.pic = "119";
            itemList.Add(item);

            item = new Items();
            item.name = "Chase Value Centre Mens Y/D PC Polo T-Shirt BIKE";
            item.price = 399;
            item.quantity = 13;
            item.color = "Multicolor";
            item.barcode = "MWP0001";
            item.material = "PC Jersey";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "Polo";
            item.pic = "120";
            itemList.Add(item);

            item = new Items();
            item.name = "Smart Clozet Green Independence Day Cotton Polo Shirt";
            item.price = 350;
            item.quantity = 10;
            item.color = "Green";
            item.barcode = "MWP0002";
            item.material = "Cotton";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "Polo";
            item.pic = "121";
            itemList.Add(item);

            item = new Items();
            item.name = "IDOL Fashion Pack of 2 Pakistan Pocket Flag Independence Day Polo Shirt for Men. IDF-PK513";
            item.price = 750;
            item.quantity = 4;
            item.color = "Green,White";
            item.barcode = "MWP0003";
            item.material = "Cotton";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "Polo";
            item.pic = "122";
            itemList.Add(item);

            item = new Items();
            item.name = "LEVIS Multicolor Pique Ss Sunset Polo Lt for Men";
            item.price = 1499;
            item.quantity = 13;
            item.color = "Multicolor";
            item.barcode = "MWP0004";
            item.material = "Pique";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "Polo";
            item.pic = "123";
            itemList.Add(item);

            item = new Items();
            item.name = "Fashion Avenue BLUE BLACK CHECKERED CASUAL SHIRT FOR MEN";
            item.price = 1499;
            item.quantity = 7;
            item.color = "Blue";
            item.barcode = "MWTS0001";
            item.material = "Cotton";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "Tops and Shirts";
            item.pic = "124";
            itemList.Add(item);

            item = new Items();
            item.name = "IGNITE Pearl Blue Cotton Casual Shirt for Men";
            item.price = 899;
            item.quantity = 9;
            item.color = "Pearl Blue";
            item.barcode = "MWTS0002";
            item.material = "Cotton";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "Tops and Shirts";
            item.pic = "125";
            itemList.Add(item);

            item = new Items();
            item.name = "IGNITE Green Grey Cotton Block Print Shirt for Men";
            item.price = 899;
            item.quantity = 7;
            item.color = "Green Grey";
            item.barcode = "MWTS0003";
            item.material = "Cotton";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "Tops and Shirts";
            item.pic = "126";
            itemList.Add(item);

            item = new Items();
            item.name = "SA Bazaar Men Checked Casual Shirt";
            item.price = 1120;
            item.quantity = 4;
            item.color = "Multicolor";
            item.barcode = "MWTS0004";
            item.material = "Cotton";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "Tops and Shirts";
            item.pic = "127";
            itemList.Add(item);

            item = new Items();
            item.name = "The Warehouse glow nebula jogger pant";
            item.price = 2899;
            item.quantity = 2;
            item.color = "Multicolor";
            item.barcode = "MWPT0001";
            item.material = "Other";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "Trousers and Pants";
            item.pic = "128";
            itemList.Add(item);

            item = new Items();
            item.name = "Marco Navy Blue Checkered Cotton Pajama - MPF 10";
            item.price = 249;
            item.quantity = 12;
            item.color = "Navy Blue";
            item.barcode = "MWPT0002";
            item.material = "Cotton";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "Trousers and Pants";
            item.pic = "129";
            itemList.Add(item);

            item = new Items();
            item.name = "Marco Navy Blue Checkered Cotton Pajama - MPF 10";
            item.price = 899;
            item.quantity = 6;
            item.color = "Grey, Black";
            item.barcode = "MWPT0003";
            item.material = "Cotton";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "Trousers and Pants";
            item.pic = "130";
            itemList.Add(item);

            item = new Items();
            item.name = "A&G Pack of 2 - Grey Blue Fleece Trouser for Men";
            item.price = 799;
            item.quantity = 5;
            item.color = "Grey Blue";
            item.barcode = "MWPT0004";
            item.material = "Fleece";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "Trousers and Pants";
            item.pic = "131";
            itemList.Add(item);

            item = new Items();
            item.name = "Denizen Core Slim Straight Cloud Cream Special Online Price";
            item.price = 1800;
            item.quantity = 5;
            item.color = "Blue";
            item.barcode = "MWJ0001";
            item.material = "Denim";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "Jeans";
            item.pic = "132";
            itemList.Add(item);

            item = new Items();
            item.name = "Denizen Core Slim Straight Mood Yellow Special Online Price";
            item.price = 1699;
            item.quantity = 5;
            item.color = "Black";
            item.barcode = "MWJ0002";
            item.material = "Denim";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "Jeans";
            item.pic = "133";
            itemList.Add(item);

            item = new Items();
            item.name = "Denizen Grey Cotton Chinos for Men";
            item.price = 999;
            item.quantity = 5;
            item.color = "Grey";
            item.barcode = "MWJ0003";
            item.material = "Cotton";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "Jeans";
            item.pic = "134";
            itemList.Add(item);

            item = new Items();
            item.name = "LEVIS 511™ Slim Fit Rascal Special Online Price";
            item.price = 2000;
            item.quantity = 5;
            item.color = "Beige";
            item.barcode = "MWJ0004";
            item.material = "Denim";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "Jeans";
            item.pic = "135";
            itemList.Add(item);

            item = new Items();
            item.name = "Chase Value Centre Men's Cotton Shorts Plain";
            item.price = 299;
            item.quantity = 15;
            item.color = "Beige";
            item.barcode = "MWS0001";
            item.material = "Cotton";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "Shorts";
            item.pic = "136";
            itemList.Add(item);

            item = new Items();
            item.name = "A&G A&G-Bundle of 2 Short for Men";
            item.price = 769;
            item.quantity = 5;
            item.color = "Multicolor";
            item.barcode = "MWS0002";
            item.material = "Cotton";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "Shorts";
            item.pic = "137";
            itemList.Add(item);

            item = new Items();
            item.name = "IGNITE Mens Short Beige Plain For Men";
            item.price = 299;
            item.quantity = 15;
            item.color = "Beige";
            item.barcode = "MWS0003";
            item.material = "Cotton";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "Shorts";
            item.pic = "138";
            itemList.Add(item);

            item = new Items();
            item.name = "ABBY Black Jeans Short For Men";
            item.price = 598;
            item.quantity = 7;
            item.color = "Black";
            item.barcode = "MWS0004";
            item.material = "Denim";
            item.category = "Men";
            item.category1 = "Westren Clothing";
            item.category2 = "Shorts";
            item.pic = "139";
            itemList.Add(item);

            item = new Items();
            item.name = "Junaid Jamshed MID NIGHT BLUE P.V Men's Kameez Shalwar -Eid ul Fiter Collection 2018";
            item.price = 3298;
            item.quantity = 5;
            item.color = "Mid Night Blue";
            item.barcode = "MPKS0001";
            item.material = "Polyester Viscose";
            item.category = "Men";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Shalwar Kamiz";
            item.pic = "140";
            itemList.Add(item);

            item = new Items();
            item.name = "Junaid Jamshed BLACK Polyester Viscose Men's Regular KS Eid ul Azha Collection Vol-03";
            item.price = 4268;
            item.quantity = 5;
            item.color = "Light Grey";
            item.barcode = "MPKS0002";
            item.material = "Polyester Viscose";
            item.category = "Men";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Shalwar Kamiz";
            item.pic = "141";
            itemList.Add(item);

            item = new Items();
            item.name = "Junaid Jamshed CHARCOAL GREY Polyester Viscose Men's Regular KS Eid ul Azha Collection Vol-03";
            item.price = 3968;
            item.quantity = 7;
            item.color = "Charcol Grey";
            item.barcode = "MPKS0003";
            item.material = "Polyester Viscose";
            item.category = "Men";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Shalwar Kamiz";
            item.pic = "142";
            itemList.Add(item);

            item = new Items();
            item.name = "Edge Kameez Shalwar Black Snipper Chk Box";
            item.price = 5500;
            item.quantity = 2;
            item.color = "Black";
            item.barcode = "MPKS0004";
            item.material = "Viscose";
            item.category = "Men";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Shalwar Kamiz";
            item.pic = "143";
            itemList.Add(item);

            item = new Items();
            item.name = "Chase Value Centre Light Green Poly Viscose Men's Basic Slim Fit Kurta";
            item.price = 499;
            item.quantity = 12;
            item.color = "Black";
            item.barcode = "MPK0001";
            item.material = "Viscose";
            item.category = "Men";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Kurtas";
            item.pic = "144";
            itemList.Add(item);

            item = new Items();
            item.name = "Chase Value Centre Light Green Poly Viscose Men's Basic Slim Fit Kurta";
            item.price = 2752;
            item.quantity = 12;
            item.color = "Dark Brown";
            item.barcode = "MPK0002";
            item.material = "Rich Cotton";
            item.category = "Men";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Kurtas";
            item.pic = "145";
            itemList.Add(item);

            item = new Items();
            item.name = "Bonanza Satrangi Blue Men Kurta";
            item.price = 2304;
            item.quantity = 4;
            item.color = "Blue";
            item.barcode = "MPK0003";
            item.material = "Cotton";
            item.category = "Men";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Kurtas";
            item.pic = "146";
            itemList.Add(item);

            item = new Items();
            item.name = "Bonanza Satrangi White Men Kurta";
            item.price = 3184;
            item.quantity = 2;
            item.color = "White";
            item.barcode = "MPK0004";
            item.material = "Polyester Cotton";
            item.category = "Men";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Kurtas";
            item.pic = "147";
            itemList.Add(item);

            item = new Items();
            item.name = "Shahzeb Saeed Black & royal Blue Jamawar Waist Coat";
            item.price = 1799;
            item.quantity = 5;
            item.color = "	Black & Royal Blue";
            item.barcode = "MPW0001";
            item.material = "Jamawar";
            item.category = "Men";
            item.category1 = "Pakistani Clothing";
            item.category2 = "WaistCoat";
            item.pic = "148";
            itemList.Add(item);

            item = new Items();
            item.name = "Shahzeb Saeed Black & royal Blue Jamawar Waist Coat";
            item.price = 5213;
            item.quantity = 2;
            item.color = "Beige";
            item.barcode = "MPW0002";
            item.material = "BLENDED";
            item.category = "Men";
            item.category1 = "Pakistani Clothing";
            item.category2 = "WaistCoat";
            item.pic = "149";
            itemList.Add(item);
            
            item = new Items();
            item.name = "Almirah Off White WAIST COAT Summer Collection Vol:03-2018";
            item.price = 3250;
            item.quantity = 5;
            item.color = "Off White";
            item.barcode = "MPW0003";
            item.material = "Blended";
            item.category = "Men";
            item.category1 = "Pakistani Clothing";
            item.category2 = "WaistCoat";
            item.pic = "150";
            itemList.Add(item);

            item = new Items();
            item.name = "Imported Persian Waistcoat";
            item.price = 12000;
            item.quantity = 1;
            item.color = "Black & Royal Blue";
            item.barcode = "MPW0004";
            item.material = "Imported Persian Fabric";
            item.category = "Men";
            item.category1 = "Pakistani Clothing";
            item.category2 = "WaistCoat";
            item.pic = "151";
            itemList.Add(item);

            item = new Items();
            item.name = "ALHamra Navy Blue Wash & Wear Unstitched Kurta for Men";
            item.price = 399;
            item.quantity = 12;
            item.color = "Navy Blue";
            item.barcode = "MPU0001";
            item.material = "Wash & Wear";
            item.category = "Men";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Unstiched";
            item.pic = "152";
            itemList.Add(item);

            item = new Items();
            item.name = "ALHamra Chocolate Brown Wash & Wear Unstitched Kurta for Men";
            item.price = 550;
            item.quantity = 7;
            item.color = "Chocolate Brown";
            item.barcode = "MPU0002";
            item.material = "Wash & Wear";
            item.category = "Men";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Unstiched";
            item.pic = "153";
            itemList.Add(item);

            item = new Items();
            item.name = "FashionValley Khadar Suit, Traditional Wear For Men- 2 Pcs- Brown";
            item.price = 1499;
            item.quantity = 3;
            item.color = "Brown";
            item.barcode = "MPU0003";
            item.material = "Khaddar";
            item.category = "Men";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Unstiched";
            item.pic = "154";
            itemList.Add(item);

            item = new Items();
            item.name = "Dealz On Hai Unstitched Beige Wash & Wear Suit 4 Meters";
            item.price = 700;
            item.quantity = 10;
            item.color = "Beige";
            item.barcode = "MPU0004";
            item.material = "Wash & Wear";
            item.category = "Men";
            item.category1 = "Pakistani Clothing";
            item.category2 = "Unstiched";
            item.pic = "155";
            itemList.Add(item);

            item = new Items();
            item.name = "Moncler Brown Leather Jacket For Men";
            item.price = 2699;
            item.quantity = 10;
            item.color = "Brown";
            item.barcode = "MWJA0001";
            item.material = "Faux Leather";
            item.category = "Men";
            item.category1 = "Winter Wear";
            item.category2 = "Jackets and Coats";
            item.pic = "155";
            itemList.Add(item);

            item = new Items();
            item.name = "Aybeez Stylish Black Fleece Jacket For Men";
            item.price = 1399;
            item.quantity = 7;
            item.color = "Black";
            item.barcode = "MWJA0002";
            item.material = "Fleece";
            item.category = "Men";
            item.category1 = "Winter Wear";
            item.category2 = "Jackets and Coats";
            item.pic = "157";
            itemList.Add(item);

            item = new Items();
            item.name = "Aybeez Black Cotton Mexican Jacket with Front Pocket for Men";
            item.price = 699;
            item.quantity = 10;
            item.color = "Black";
            item.barcode = "MWJA0003";
            item.material = "Cotton";
            item.category = "Men";
            item.category1 = "Winter Wear";
            item.category2 = "Jackets and Coats";
            item.pic = "158";
            itemList.Add(item);

            item = new Items();
            item.name = "Prime Black Men Slim Fit Pu Leather Jacket - D-BROWN-B666";
            item.price = 2500;
            item.quantity = 10;
            item.color = "Dark Brown";
            item.barcode = "MWJA0004";
            item.material = "PU Leather";
            item.category = "Men";
            item.category1 = "Winter Wear";
            item.category2 = "Jackets and Coats";
            item.pic = "159";
            itemList.Add(item);

            item = new Items();
            item.name = "Aybeez Grey Fleece Hoodie for Men";
            item.price = 1599;
            item.quantity = 8;
            item.color = "Grey";
            item.barcode = "MWH0001";
            item.material = "Fleece";
            item.category = "Men";
            item.category1 = "Winter Wear";
            item.category2 = "Hoodies";
            item.pic = "160";
            itemList.Add(item);

            item = new Items();
            item.name = "BnB Accessories Black with Grey Shoulder Patch Kangaroo Hoodie";
            item.price = 699;
            item.quantity = 8;
            item.color = "Black";
            item.barcode = "MWH0002";
            item.material = "Fleece";
            item.category = "Men";
            item.category1 = "Winter Wear";
            item.category2 = "Hoodies";
            item.pic = "161";
            itemList.Add(item);

            item = new Items();
            item.name = "Aybeez Grey Fleece Hoodie for Men";
            item.price = 696;
            item.quantity = 8;
            item.color = "Black";
            item.barcode = "MWH0003";
            item.material = "Fleece";
            item.category = "Men";
            item.category1 = "Winter Wear";
            item.category2 = "Hoodies";
            item.pic = "162";
            itemList.Add(item);

            item = new Items();
            item.name = "BnB Accessories Heather Grey With Navy Blue Contrast Hoodie";
            item.price = 599;
            item.quantity = 18;
            item.color = "Heather Grey";
            item.barcode = "MWH0004";
            item.material = "Fleece";
            item.category = "Men";
            item.category1 = "Winter Wear";
            item.category2 = "Hoodies";
            item.pic = "163";
            itemList.Add(item);

            item = new Items();
            item.name = "Oasis Woodland Brown Leather Traditional Peshawari Sandals for Men";
            item.price = 448;
            item.quantity = 8;
            item.color = "Brown";
            item.barcode = "MSS0001";
            item.material = "Leather";
            item.category = "Men";
            item.category1 = "Shoes";
            item.category2 = "Sandals and Slippers";
            item.pic = "164";
            itemList.Add(item);

            item = new Items();
            item.name = "MNcollection Trendy Design Casual Sandal For Men";
            item.price = 2500;
            item.quantity = 5;
            item.color = "Black";
            item.barcode = "MSS0002";
            item.material = "Synthetic";
            item.category = "Men";
            item.category1 = "Shoes";
            item.category2 = "Sandals and Slippers";
            item.pic = "165";
            itemList.Add(item);

            item = new Items();
            item.name = "KNYALI HOUSE Kn-M-029 Leather Hand-Made Black Traditional Peshawri Chappal For Men";
            item.price = 1715;
            item.quantity = 10;
            item.color = "Black";
            item.barcode = "MSS0003";
            item.material = "Leather";
            item.category = "Men";
            item.category1 = "Shoes";
            item.category2 = "Sandals and Slippers";
            item.pic = "166";
            itemList.Add(item);

            item = new Items();
            item.name = "KNYALI HOUSE Kn-M-038 Leather & Jeans Hand-Made Brown Traditional Peshawri Chappal For Men";
            item.price = 1715;
            item.quantity = 8;
            item.color = "Brown";
            item.barcode = "MSS0004";
            item.material = "Leather";
            item.category = "Men";
            item.category1 = "Shoes";
            item.category2 = "Sandals and Slippers";
            item.pic = "167";
            itemList.Add(item);

            item = new Items();
            item.name = "Mardan Shoes Mardan Shoes Black Rubber Slippers for Men";
            item.price = 319;
            item.quantity = 8;
            item.color = "Black";
            item.barcode = "MSS0005";
            item.material = "Rubber";
            item.category = "Men";
            item.category1 = "Shoes";
            item.category2 = "Sandals and Slippers";
            item.pic = "168";
            itemList.Add(item);

            item = new Items();
            item.name = "Mardan Shoes Red Rubber Flip Flops For Men";
            item.price = 279;
            item.quantity = 5;
            item.color = "Red";
            item.barcode = "MSS0006";
            item.material = "Rubber";
            item.category = "Men";
            item.category1 = "Shoes";
            item.category2 = "Sandals and Slippers";
            item.pic = "169";
            itemList.Add(item);

            item = new Items();
            item.name = "Zaib Black Rubber Moccasins for Men";
            item.price = 249;
            item.quantity = 5;
            item.color = "Black";
            item.barcode = "MSC0001";
            item.material = "Rubber";
            item.category = "Men";
            item.category1 = "Shoes";
            item.category2 = "Casual Shoes";
            item.pic = "170";
            itemList.Add(item);

            item = new Items();
            item.name = "Milano Mall Black Leather Moccasins For Men";
            item.price = 899;
            item.quantity = 5;
            item.color = "Black";
            item.barcode = "MSC0002";
            item.material = "Leather";
            item.category = "Men";
            item.category1 = "Shoes";
            item.category2 = "Casual Shoes";
            item.pic = "171";
            itemList.Add(item);

            item = new Items();
            item.name = "Zaib Brown Rubber Moccasins for Men";
            item.price = 499;
            item.quantity = 5;
            item.color = "Brown";
            item.barcode = "MSC0003";
            item.material = "Rubber";
            item.category = "Men";
            item.category1 = "Shoes";
            item.category2 = "Casual Shoes";
            item.pic = "172";
            itemList.Add(item);

            item = new Items();
            item.name = "Techmanistan Black Rubber Slip ons";
            item.price = 299;
            item.quantity = 4;
            item.color = "Black";
            item.barcode = "MSC0004";
            item.material = "Rubber";
            item.category = "Men";
            item.category1 = "Shoes";
            item.category2 = "Casual Shoes";
            item.pic = "173";
            itemList.Add(item);

            item = new Items();
            item.name = "Starlet Shoes Black Formal & Semi Formal Cow Leather Shoes For Men";
            item.price = 3840;
            item.quantity = 4;
            item.color = "Black";
            item.barcode = "MSF0001";
            item.material = "Cow Leather";
            item.category = "Men";
            item.category1 = "Shoes";
            item.category2 = "Formal Shoes";
            item.pic = "174";
            itemList.Add(item);

            item = new Items();
            item.name = "VOGUE FLAIR Enzo Monk Strap";
            item.price = 9000;
            item.quantity = 2;
            item.color = "Brown";
            item.barcode = "MSF0002";
            item.material = "Leather";
            item.category = "Men";
            item.category1 = "Shoes";
            item.category2 = "Formal Shoes";
            item.pic = "175";
            itemList.Add(item);

            item = new Items();
            item.name = "MD Brown Leather Loafers For Men";
            item.price = 2000;
            item.quantity = 10;
            item.color = "Brown";
            item.barcode = "MSF0003";
            item.material = "Leather";
            item.category = "Men";
            item.category1 = "Shoes";
            item.category2 = "Formal Shoes";
            item.pic = "176";
            itemList.Add(item);

            item = new Items();
            item.name = "Bindiya Collection Stylish Leather Shoes For Men - Brown";
            item.price = 1839;
            item.quantity = 4;
            item.color = "Brown";
            item.barcode = "MSF0004";
            item.material = "Leather";
            item.category = "Men";
            item.category1 = "Shoes";
            item.category2 = "Formal Shoes";
            item.pic = "177";
            itemList.Add(item);

            item = new Items();
            item.name = "Bachat Express Sneakers White & Black For Woman";
            item.price = 1750;
            item.quantity = 14;
            item.color = "White";
            item.barcode = "MSSN0001";
            item.material = "PU Leather";
            item.category = "Men";
            item.category1 = "Shoes";
            item.category2 = "Sneakers";
            item.pic = "178";
            itemList.Add(item);

            item = new Items();
            item.name = "Shahzad Anwar Choco Brown Back Laces Sneaker";
            item.price = 659;
            item.quantity = 14;
            item.color = "Brown";
            item.barcode = "MSSN0002";
            item.material = "Rexine";
            item.category = "Men";
            item.category1 = "Shoes";
            item.category2 = "Sneakers";
            item.pic = "179";
            itemList.Add(item);

            item = new Items();
            item.name = "Shahzad Anwar Brown Rexine Lifestyle Sneakers For Men";
            item.price = 799;
            item.quantity = 12;
            item.color = "Brown";
            item.barcode = "MSSN0003";
            item.material = "Rexine";
            item.category = "Men";
            item.category1 = "Shoes";
            item.category2 = "Sneakers";
            item.pic = "180";
            itemList.Add(item);

            item = new Items();
            item.name = "Khokhar Stockits Brown Canvas Stylish Sneakers For Men";
            item.price = 1299;
            item.quantity = 4;
            item.color = "Brown";
            item.barcode = "MSSN0004";
            item.material = "Denim";
            item.category = "Men";
            item.category1 = "Shoes";
            item.category2 = "Sneakers";
            item.pic = "181";
            itemList.Add(item);

            item = new Items();
            item.name = "Khokhar Stockits Brown Canvas Stylish Sneakers For Men";
            item.price = 3999;
            item.quantity = 4;
            item.color = "Black";
            item.barcode = "MSB0001";
            item.material = "Phylon";
            item.category = "Men";
            item.category1 = "Shoes";
            item.category2 = "Boots";
            item.pic = "182";
            itemList.Add(item);

            item = new Items();
            item.name = "Corio Footwear Ankle Full Brogue with Wing Toe Boot for Men";
            item.price = 6300;
            item.quantity = 5;
            item.color = "Brown";
            item.barcode = "MSB0002";
            item.material = "Cow Leather";
            item.category = "Men";
            item.category1 = "Shoes";
            item.category2 = "Boots";
            item.pic = "183";
            itemList.Add(item);

            item = new Items();
            item.name = "BROADRIDINGWEAR Brown Leather Boots For Polo Rider";
            item.price = 8800;
            item.quantity = 2;
            item.color = "Brown";
            item.barcode = "MSB0003";
            item.material = "Cowhide Leather";
            item.category = "Men";
            item.category1 = "Shoes";
            item.category2 = "Boots";
            item.pic = "184";
            itemList.Add(item);

            item = new Items();
            item.name = "Army High Ankle Boots for Men";
            item.price = 1490;
            item.quantity = 5;
            item.color = "Beige";
            item.barcode = "MSB0004";
            item.material = "Leather";
            item.category = "Men";
            item.category1 = "Shoes";
            item.category2 = "Boots";
            item.pic = "185";
            itemList.Add(item);

            item = new Items();
            item.name = "Chase Value Centre Mens Artificial Leather Wallet";
            item.price = 199;
            item.quantity = 5;
            item.color = "Black";
            item.barcode = "MAW0001";
            item.material = "Leather";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Wallets and Cardholders";
            item.pic = "186";
            itemList.Add(item);

            item = new Items();
            item.name = "Deal Souk Cow Leather - 19 Pocket Wallet for Men";
            item.price = 1049;
            item.quantity = 15;
            item.color = "Black";
            item.barcode = "MAW0002";
            item.material = "Leather";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Wallets and Cardholders";
            item.pic = "187";
            itemList.Add(item);

            item = new Items();
            item.name = "Herbalstore1 Book Style Cow Leather Wallet - Brown";
            item.price = 980;
            item.quantity = 5;
            item.color = "Brown";
            item.barcode = "MAW0003";
            item.material = "Leather";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Wallets and Cardholders";
            item.pic = "188";
            itemList.Add(item);

            item = new Items();
            item.name = "Attaris Communication Aluma Wallet Aluminum Credit Card Holder";
            item.price = 300;
            item.quantity = 10;
            item.color = "Silver";
            item.barcode = "MAW0004";
            item.material = "Plastic";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Wallets and Cardholders";
            item.pic = "189";
            itemList.Add(item);

            item = new Items();
            item.name = "Shahzeb Saeed White Steel Shoes Cufflinks for Men";
            item.price = 899;
            item.quantity = 5;
            item.color = "White";
            item.barcode = "MAT0001";
            item.material = "Steel";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Ties and Cufflins";
            item.pic = "190";
            itemList.Add(item);

            item = new Items();
            item.name = "AJIZ Luxry Shirt Cufflink - Black & Golden";
            item.price = 2499;
            item.quantity = 5;
            item.color = "Black and Golden";
            item.barcode = "MAT0002";
            item.material = "Stainless Steel";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Ties and Cufflins";
            item.pic = "191";
            itemList.Add(item);

            item = new Items();
            item.name = "MA Fashion Silver Plated Apple Design Cufflinks";
            item.price = 599;
            item.quantity = 5;
            item.color = "Red";
            item.barcode = "MAT0003";
            item.material = "Metal";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Ties and Cufflins";
            item.pic = "192";
            itemList.Add(item);

            item = new Items();
            item.name = "Koy MULTI COLOUR LEGACY COLLECTION TIES";
            item.price = 399;
            item.quantity = 15;
            item.color = "Red";
            item.barcode = "MAT0004";
            item.material = "Silk";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Ties and Cufflins";
            item.pic = "193";
            itemList.Add(item);

            item = new Items();
            item.name = "Koy MULTI COLOUR LEGACY COLLECTION TIES";
            item.price = 349;
            item.quantity = 5;
            item.color = "Dark Green";
            item.barcode = "MAT0005";
            item.material = "Silk";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Ties and Cufflins";
            item.pic = "194";
            itemList.Add(item);

            item = new Items();
            item.name = "Ragazzo Penta-Black lens sunglasses Unisex";
            item.price = 839;
            item.quantity = 5;
            item.color = "Black";
            item.barcode = "MAE0001";
            item.material = "Plastic and Metal";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Eye Wear";
            item.pic = "195";
            itemList.Add(item);

            item = new Items();
            item.name = "Shah traders Black Stylish Sunglasses For Men - - Str-0030";
            item.price = 1199;
            item.quantity = 9;
            item.color = "Black";
            item.barcode = "MAE0002";
            item.material = "Metal";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Eye Wear";
            item.pic = "196";
            itemList.Add(item);

            item = new Items();
            item.name = "JD-19 NEW Design Fashion Sunglasses";
            item.price = 899;
            item.quantity = 15;
            item.color = "Black";
            item.barcode = "MAE0003";
            item.material = "Steel";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Eye Wear";
            item.pic = "197";
            itemList.Add(item);

            item = new Items();
            item.name = "Aviators 3025 U.S. Military-Randolph Aviator Sunglasses For Men -SILVER - Adjustable";
            item.price = 2199;
            item.quantity = 5;
            item.color = "Silver";
            item.barcode = "MAE0004";
            item.material = "Metal";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Eye Wear";
            item.pic = "198";
            itemList.Add(item);

            item = new Items();
            item.name = "LEVIS Batwing Sling";
            item.price = 899;
            item.quantity = 15;
            item.color = "Red";
            item.barcode = "MABA0001";
            item.material = "Polyester";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Bags";
            item.pic = "199";
            itemList.Add(item);

            item = new Items();
            item.name = "Lenovo Lenovo ThinkPad Basic laptop bag 15.4 Briefcase Black";
            item.price = 1350;
            item.quantity = 5;
            item.color = "Black";
            item.barcode = "MABA0002";
            item.material = "Polyester";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Bags";
            item.pic = "200";
            itemList.Add(item);

            item = new Items();
            item.name = "Shop N Stop Anti Theft Bag Design Grey Backpack With Usb Chargg Port";
            item.price = 3500;
            item.quantity = 15;
            item.color = "Grey and Black";
            item.barcode = "MABA0003";
            item.material = "Mix";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Bags";
            item.pic = "201";
            itemList.Add(item);

            item = new Items();
            item.name = "Bestone Bestone Anti-Theft Bag With Usb Charging Port - Black";
            item.price = 1999;
            item.quantity = 15;
            item.color = "Black";
            item.barcode = "MABA0004";
            item.material = "Mix";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Bags";
            item.pic = "202";
            itemList.Add(item);

            item = new Items();
            item.name = "Shahzeb Saeed Leather Black Belt";
            item.price = 999;
            item.quantity = 15;
            item.color = "Black";
            item.barcode = "MAB0001";
            item.material = "Leather";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Belts";
            item.pic = "203";
            itemList.Add(item);

            item = new Items();
            item.name = "LEVIS Light Brown Leather Belt For Men";
            item.price = 1130;
            item.quantity = 15;
            item.color = "Light Brown";
            item.barcode = "MAB0002";
            item.material = "Leather";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Belts";
            item.pic = "204";
            itemList.Add(item);

            item = new Items();
            item.name = "Sheikh Leather Black Leather Belt for Men";
            item.price = 800;
            item.quantity = 15;
            item.color = "Black";
            item.barcode = "MAB0003";
            item.material = "Leather";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Belts";
            item.pic = "205";
            itemList.Add(item);

            item = new Items();
            item.name = "Koy KOY BRAIDED COLLECTION- CASUAL BRAIDED & LEATHER FINISH BELT FOR MEN";
            item.price = 499;
            item.quantity = 15;
            item.color = "Electric Blue";
            item.barcode = "MAB0004";
            item.material = "Leather , Alloy , Spandex";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Belts";
            item.pic = "206";
            itemList.Add(item);

            item = new Items();
            item.name = "LEVIS Big Batwing Flex Fit Cap for Men";
            item.price = 1699;
            item.quantity = 10;
            item.color = "Red";
            item.barcode = "MAC0001";
            item.material = "Cotton";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Caps and Gloves";
            item.pic = "207";
            itemList.Add(item);

            item = new Items();
            item.name = "MARKHOR VICTORY Green Cap with Pakistan Flag";
            item.price = 499;
            item.quantity = 10;
            item.color = "Green";
            item.barcode = "MAC0002";
            item.material = "Velvet";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Caps and Gloves";
            item.pic = "208";
            itemList.Add(item);

            item = new Items();
            item.name = "Saim Collections Tactical Gloves Military Rubber Hard Knuckle Outdoor Gloves For Men Fit For Cycling Motorcycle Hiking";
            item.price = 795;
            item.quantity = 7;
            item.color = "Camel";
            item.barcode = "MAC0003";
            item.material = "Plastic";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Caps and Gloves";
            item.pic = "209";
            itemList.Add(item);

            item = new Items();
            item.name = "Ak Enterprises Black Leather Pro Biker Gloves - G21LO00CE001";
            item.price = 999;
            item.quantity = 10;
            item.color = "Black";
            item.barcode = "MAC0004";
            item.material = "Leather";
            item.category = "Men";
            item.category1 = "Accessories";
            item.category2 = "Caps and Gloves";
            item.pic = "210";
            itemList.Add(item);

            item = new Items();
            item.name = "BnB Accessories Threadbare Grey Fleece Sweatshirt";
            item.price = 599;
            item.quantity = 18;
            item.color = "Grey";
            item.barcode = "MWSW0001";
            item.material = "Fleece";
            item.category = "Men";
            item.category1 = "Winter Wear";
            item.category2 = "Sweaters";
            item.pic = "211";
            itemList.Add(item);

            item = new Items();
            item.name = "Just Clothing Black Fleece Sweat Shirt Legends Are Born In November";
            item.price = 399;
            item.quantity = 8;
            item.color = "Black";
            item.barcode = "MWSW0002";
            item.material = "Fleece";
            item.category = "Men";
            item.category1 = "Winter Wear";
            item.category2 = "Sweaters";
            item.pic = "212";
            itemList.Add(item);

            item = new Items();
            item.name = "CLOTHING PALETTE maroon beach please";
            item.price = 850;
            item.quantity = 10;
            item.color = "Maroon";
            item.barcode = "MWSW0003";
            item.material = "Fleece";
            item.category = "Men";
            item.category1 = "Winter Wear";
            item.category2 = "Sweaters";
            item.pic = "213";
            itemList.Add(item);

            item = new Items();
            item.name = "The Hangers Bundle of 2 - Winter Panel Sweatshirt for Men";
            item.price = 2500;
            item.quantity = 5;
            item.color = "Multicolor";
            item.barcode = "MWSW0004";
            item.material = "Cotton";
            item.category = "Men";
            item.category1 = "Winter Wear";
            item.category2 = "Sweaters";
            item.pic = "214";
            itemList.Add(item);

            item = new Items();
            item.name = "Daraz Fashion Fitness Tracker Smart Band Smart Watch";
            item.price = 35492;
            item.quantity = 5;
            item.color = "Brown";
            item.barcode = "MWSM0001";
            item.material = "Leather";
            item.category = "Men";
            item.category1 = "Watches";
            item.category2 = "Smart";
            item.pic = "215";
            itemList.Add(item);

            item = new Items();
            item.name = "Best buy Smart Watch Y1 With GSM Slot For IOS And Android With Camera";
            item.price = 1899;
            item.quantity = 10;
            item.color = "Black";
            item.barcode = "MWSM0002";
            item.material = "Plastic and Rubber";
            item.category = "Men";
            item.category1 = "Watches";
            item.category2 = "Smart";
            item.pic = "216";
            itemList.Add(item);

            item = new Items();
            item.name = "Getiit Fit Smart Fitness Band - Black";
            item.price = 2499;
            item.quantity = 15;
            item.color = "Black";
            item.barcode = "MWSM0003";
            item.material = "Rubber";
            item.category = "Men";
            item.category1 = "Watches";
            item.category2 = "Smart";
            item.pic = "217";
            itemList.Add(item);

            item = new Items();
            item.name = "ASUS ZenWatch 2 Android Wear - Beige";
            item.price = 15999;
            item.quantity = 5;
            item.color = "Beige";
            item.barcode = "MWSM0004";
            item.material = "Metal";
            item.category = "Men";
            item.category1 = "Watches";
            item.category2 = "Smart";
            item.pic = "218";
            itemList.Add(item);

            item = new Items();
            item.name = "Casio MTP-1381L-1AVDF - Analog Watch for Men - Black";
            item.price = 3799;
            item.quantity = 4;
            item.color = "Black";
            item.barcode = "MWAN0001";
            item.material = "Leather";
            item.category = "Men";
            item.category1 = "Watches";
            item.category2 = "Analog";
            item.pic = "219";
            itemList.Add(item);

            item = new Items();
            item.name = "Curren Stylish Men's Curren Leather Watch";
            item.price = 499;
            item.quantity = 6;
            item.color = "Black and Brown";
            item.barcode = "MWAN0002";
            item.material = "Leather and Steel";
            item.category = "Men";
            item.category1 = "Watches";
            item.category2 = "Analog";
            item.pic = "221";
            itemList.Add(item);

            item = new Items();
            item.name = "Kureshi Collections Pack of 2 - Blue & Brown Leather Strap Analog Watch";
            item.price = 549;
            item.quantity = 4;
            item.color = "Brown and Blue";
            item.barcode = "MWAN0003";
            item.material = "Leather";
            item.category = "Men";
            item.category1 = "Watches";
            item.category2 = "Analog";
            item.pic = "220";
            itemList.Add(item);

            item = new Items();
            item.name = "Daraz Fashion Black Stainless Steel & Leather Analog Watch for Men";
            item.price = 499;
            item.quantity =10;
            item.color = "Black";
            item.barcode = "MWAN0004";
            item.material = "Steel";
            item.category = "Men";
            item.category1 = "Watches";
            item.category2 = "Analog";
            item.pic = "222";
            itemList.Add(item);

            item = new Items();
            item.name = "Daraz Fashion Military Sports Chronograph Dual Time Wrist Watch for Men";
            item.price = 889;
            item.quantity = 10;
            item.color = "Black";
            item.barcode = "MWCG0001";
            item.material = "Plastic and Rubber";
            item.category = "Men";
            item.category1 = "Watches";
            item.category2 = "Cornograph";
            item.pic = "223";
            itemList.Add(item);

            item = new Items();
            item.name = "Diesel Black Stainless Steel Watch for Men - DZ7362";
            item.price = 2799;
            item.quantity = 8;
            item.color = "Black";
            item.barcode = "MWCG0002";
            item.material = "Stainless Steel";
            item.category = "Men";
            item.category1 = "Watches";
            item.category2 = "Cornograph";
            item.pic = "224";
            itemList.Add(item);

            item = new Items();
            item.name = "Curren 8184 - Alloy Fashionable Wrist Watch";
            item.price = 1400;
            item.quantity = 10;
            item.color = "White";
            item.barcode = "MWCG0003";
            item.material = "Alloy";
            item.category = "Men";
            item.category1 = "Watches";
            item.category2 = "Cornograph";
            item.pic = "225";
            itemList.Add(item);

            item = new Items();
            item.name = "Fossil Black Dial Stainless Steel Chronograph Watch For Men CH-3026";
            item.price = 20200;
            item.quantity = 7;
            item.color = "Silver and Black";
            item.barcode = "MWCG0004";
            item.material = "Stainless Steel";
            item.category = "Men";
            item.category1 = "Watches";
            item.category2 = "Cornograph";
            item.pic = "226";
            itemList.Add(item);

            item = new Items();
            item.name = "SKMEI SK1116 - Black Resin Pedometer Watch for Men";
            item.price = 899;
            item.quantity = 17;
            item.color = "Black and Blue";
            item.barcode = "MWDG0001";
            item.material = "PU , Resin, Hardlex";
            item.category = "Men";
            item.category1 = "Watches";
            item.category2 = "Digital";
            item.pic = "227";
            itemList.Add(item);

            item = new Items();
            item.name = "Tijarat online Sports Watch For Men - Black & Silver";
            item.price = 499;
            item.quantity = 17;
            item.color = "Black and Silver";
            item.barcode = "MWDG0002";
            item.material = "Plastic";
            item.category = "Men";
            item.category1 = "Watches";
            item.category2 = "Digital";
            item.pic = "228";
            itemList.Add(item);

            item = new Items();
            item.name = "SKMEI SKMEI 1016- Silicone- Men's Sports Watch ";
            item.price = 1350;
            item.quantity = 17;
            item.color = "Black and Golden";
            item.barcode = "MWDG0003";
            item.material = "Stainless Steel, PU silicone, Resin";
            item.category = "Men";
            item.category1 = "Watches";
            item.category2 = "Digital";
            item.pic = "229";
            itemList.Add(item);

            item = new Items();
            item.name = "Bismillah Traders Digital Junior Sports Watch";
            item.price = 128;
            item.quantity = 20;
            item.color = "Red";
            item.barcode = "MWDG0004";
            item.material = "Rubber";
            item.category = "Men";
            item.category1 = "Watches";
            item.category2 = "Digital";
            item.pic = "230";
            itemList.Add(item);

            item = new Items();
            item.name = "Chase Value Centre Boys Jersey T-Shirt H/S Green - Airforce";
            item.price = 199;
            item.quantity = 20;
            item.color = "Black";
            item.barcode = "KBCS0001";
            item.material = "PC jersey";
            item.category = "Kids";
            item.category1 = "Boy";
            item.category2 = "Clothes";
            item.category3 = "Shirts";
            item.pic = "231";
            itemList.Add(item);

            item = new Items();
            item.name = "Bachaa Party Green Cotton Boys Stripped Polo Shirt";
            item.price = 599;
            item.quantity = 10;
            item.color = "Green";
            item.barcode = "KBCS0002";
            item.material = "Cotton";
            item.category = "Kids";
            item.category1 = "Boy";
            item.category2 = "Clothes";
            item.category3 = "Shirts";
            item.pic = "232";
            itemList.Add(item);

            item = new Items();
            item.name = "FineDealz Mother Love Make Some Waves T-Shirt And Short Set For Boys";
            item.price = 4200;
            item.quantity = 5;
            item.color = "Green";
            item.barcode = "KBCS0003";
            item.material = "Cotton";
            item.category = "Kids";
            item.category1 = "Boy";
            item.category2 = "Clothes";
            item.category3 = "Shirts";
            item.pic = "233";
            itemList.Add(item);

            item = new Items();
            item.name = "FineDealz Mother Love Blue Striped Polo And Shorts Set For Boys";
            item.price = 4950;
            item.quantity = 2;
            item.color = "Blue";
            item.barcode = "KBCS0004";
            item.material = "Cotton";
            item.category = "Kids";
            item.category1 = "Boy";
            item.category2 = "Clothes";
            item.category3 = "Shirts";
            item.pic = "234";
            itemList.Add(item);

            item = new Items();
            item.name = "MS Kids Jeans Shorts-Black";
            item.price = 199;
            item.quantity = 10;
            item.color = "Black";
            item.barcode = "KBCJ0001";
            item.material = "Denim";
            item.category = "Kids";
            item.category1 = "Boy";
            item.category2 = "Clothes";
            item.category3 = "Jeans";
            item.pic = "235";
            itemList.Add(item);

            item = new Items();
            item.name = "Xero 9 Blue Soft Denim Round Elastic Jeans For Boys By Xero9";
            item.price = 1150;
            item.quantity = 4;
            item.color = "Blue";
            item.barcode = "KBCJ0002";
            item.material = "Jeans";
            item.category = "Kids";
            item.category1 = "Boy";
            item.category2 = "Clothes";
            item.category3 = "Jeans";
            item.pic = "236";
            itemList.Add(item);

            item = new Items();
            item.name = "Kids Creations Pirate Printed Boys Short";
            item.price = 265;
            item.quantity = 10;
            item.color = "Dark Blue";
            item.barcode = "KBCJ0003";
            item.material = "Terry";
            item.category = "Kids";
            item.category1 = "Boy";
            item.category2 = "Clothes";
            item.category3 = "Jeans";
            item.pic = "237";
            itemList.Add(item);

            item = new Items();
            item.name = "Madina Fashion Imported Quality Stylish Denim Blue Suspenders Short + Bermuda For Boys";
            item.price = 695;
            item.quantity = 5;
            item.color = "Blue";
            item.barcode = "KBCJ0004";
            item.material = "Denim";
            item.category = "Kids";
            item.category1 = "Boy";
            item.category2 = "Clothes";
            item.category3 = "Jeans";
            item.pic = "238";
            itemList.Add(item);

            item = new Items();
            item.name = "Bachaa Party Yellow Cotton Boys Hooded T-Shirt – Poping";
            item.price = 499;
            item.quantity = 15;
            item.color = "Yellow";
            item.barcode = "KBCW0001";
            item.material = "Cotton";
            item.category = "Kids";
            item.category1 = "Boy";
            item.category2 = "Clothes";
            item.category3 = "Winter Wear";
            item.pic = "239";
            itemList.Add(item);

            item = new Items();
            item.name = "The Warehouse Harry Potter Kids Hoodie";
            item.price = 1899;
            item.quantity = 12;
            item.color = "Maroon";
            item.barcode = "KBCW0002";
            item.material = "Mix";
            item.category = "Kids";
            item.category1 = "Boy";
            item.category2 = "Clothes";
            item.category3 = "Winter Wear";
            item.pic = "240";
            itemList.Add(item);

            item = new Items();
            item.name = "Shopaholicstep Pullover & Contrast Pocket Hoodie Suit For Baby Boys";
            item.price = 550;
            item.quantity = 15;
            item.color = "Black and White";
            item.barcode = "KBCW0003";
            item.material = "Fleece";
            item.category = "Kids";
            item.category1 = "Boy";
            item.category2 = "Clothes";
            item.category3 = "Winter Wear";
            item.pic = "241";
            itemList.Add(item);

            item = new Items();
            item.name = "Peekaboo Grey & Black Cotton French Terry Hoodie for Boys";
            item.price = 1250;
            item.quantity = 4;
            item.color = "Grey";
            item.barcode = "KBCW0004";
            item.material = "Cotton";
            item.category = "Kids";
            item.category1 = "Boy";
            item.category2 = "Clothes";
            item.category3 = "Winter Wear";
            item.pic = "242";
            itemList.Add(item);

            item = new Items();
            item.name = "YNG Empire Grey Red Sandals For Boys";
            item.price = 999;
            item.quantity = 14;
            item.color = "Grey and Red";
            item.barcode = "KBS0001";
            item.material = "Synthetic Leather & Rubber Sole";
            item.category = "Kids";
            item.category1 = "Boy";
            item.category2 = "Shoes";
            item.pic = "243";
            itemList.Add(item);

            item = new Items();
            item.name = "China Soft Sendal For Boys";
            item.price = 1700;
            item.quantity = 4;
            item.color = "Red";
            item.barcode = "KBS0002";
            item.material = "Rubber Sole";
            item.category = "Kids";
            item.category1 = "Boy";
            item.category2 = "Shoes";
            item.pic = "244";
            itemList.Add(item);

            item = new Items();
            item.name = "Imported Imported Leather Black & Green Shoes For Boy'S 411-50250";
            item.price = 999;
            item.quantity = 12;
            item.color = "Multicolor";
            item.barcode = "KBS0003";
            item.material = "Leather";
            item.category = "Kids";
            item.category1 = "Boy";
            item.category2 = "Shoes";
            item.pic = "245";
            itemList.Add(item);

            item = new Items();
            item.name = "Daraz Kids Skull Leather Band Style Watch For Boys";
            item.price = 309;
            item.quantity = 12;
            item.color = "Black";
            item.barcode = "KBA0001";
            item.material = "Steel and Leather";
            item.category = "Kids";
            item.category1 = "Boy";
            item.category2 = "Accessories";
            item.pic = "246";
            itemList.Add(item);

            item = new Items();
            item.name = "DT Pack Of 2 - Sports Digital Watches - Multi Color";
            item.price = 499;
            item.quantity = 10;
            item.color = "Black";
            item.barcode = "KBA0002";
            item.material = "Plastic";
            item.category = "Kids";
            item.category1 = "Boy";
            item.category2 = "Accessories";
            item.pic = "247";
            itemList.Add(item);

            item = new Items();
            item.name = "Love Your Baby Boys cow-boy hats 6 - 12 year";
            item.price = 529;
            item.quantity = 7;
            item.color = "Skin";
            item.barcode = "KBA0003";
            item.material = "Other";
            item.category = "Kids";
            item.category1 = "Boy";
            item.category2 = "Accessories";
            item.pic = "248";
            itemList.Add(item);

            item = new Items();
            item.name = "HADYA Alien Eyes Sunglasses For Kids - YellowBy HADYA";
            item.price = 149;
            item.quantity = 12;
            item.color = "Yellow";
            item.barcode = "KBA0004";
            item.material = "Abs";
            item.category = "Kids";
            item.category1 = "Boy";
            item.category2 = "Accessories";
            item.pic = "249";
            itemList.Add(item);

            item = new Items();
            item.name = "HADYA Lgb-01 - 21 Strap Watch Set";
            item.price = 799;
            item.quantity = 8;
            item.color = "Multicolor";
            item.barcode = "KGA0001";
            item.material = "Rubber";
            item.category = "Kids";
            item.category1 = "Girl";
            item.category2 = "Accessories";
            item.pic = "250";
            itemList.Add(item);

            item = new Items();
            item.name = "HADYA Kids Apple Style Digital Watch";
            item.price = 115;
            item.quantity = 9;
            item.color = "Pink";
            item.barcode = "KGA0002";
            item.material = "Plastic";
            item.category = "Kids";
            item.category1 = "Girl";
            item.category2 = "Accessories";
            item.pic = "251";
            itemList.Add(item);

            item = new Items();
            item.name = "7Eleven Pack Of 12 - Kids Hair Pins";
            item.price = 100;
            item.quantity = 19;
            item.color = "Blue";
            item.barcode = "KGA0003";
            item.material = "Plastic and Metal";
            item.category = "Kids";
            item.category1 = "Girl";
            item.category2 = "Accessories";
            item.pic = "252";
            itemList.Add(item);

            item = new Items();
            item.name = "Maya Traders Black Synthetic Leather Sandals for Girls - A99";
            item.price = 590;
            item.quantity = 19;
            item.color = "Black";
            item.barcode = "KGS0001";
            item.material = "Synthetic Leather";
            item.category = "Kids";
            item.category1 = "Girl";
            item.category2 = "Shoes";
            item.pic = "253";
            itemList.Add(item);

            item = new Items();
            item.name = "ZARA Sneakers With Bow Detail Shoes";
            item.price = 3499;
            item.quantity = 12;
            item.color = "Beige";
            item.barcode = "KGS0002";
            item.material = "Leather";
            item.category = "Kids";
            item.category1 = "Girl";
            item.category2 = "Shoes";
            item.pic = "254";
            itemList.Add(item);

            item = new Items();
            item.name = "Little camel Girls Garland Embellished Khussa 446655";
            item.price = 350;
            item.quantity = 15;
            item.color = "Golden";
            item.barcode = "KGS0003";
            item.material = "Synthetic Leather";
            item.category = "Kids";
            item.category1 = "Girl";
            item.category2 = "Shoes";
            item.pic = "255";
            itemList.Add(item);

            item = new Items();
            item.name = "Bachaa Party Moms Fajr Alarm Romper";
            item.price = 399;
            item.quantity = 5;
            item.color = "White";
            item.barcode = "KBBC0001";
            item.material = "Cotton";
            item.category = "Kids";
            item.category1 = "Baby";
            item.category2 = "Clothes";
            item.pic = "256";
            itemList.Add(item);

            item = new Items();
            item.name = "BrandStitch Pack Of 3 - Cotton Printed Baby Frocks";
            item.price = 599;
            item.quantity = 7;
            item.color = "Multicolor";
            item.barcode = "KBBC0002";
            item.material = "Cotton";
            item.category = "Kids";
            item.category1 = "Baby";
            item.category2 = "Clothes";
            item.pic = "257";
            itemList.Add(item);

            item = new Items();
            item.name = "Kids Creations Grey Unisex Shorts";
            item.price = 299;
            item.quantity = 5;
            item.color = "Grey";
            item.barcode = "KBBC0003";
            item.material = "Terry";
            item.category = "Kids";
            item.category1 = "Baby";
            item.category2 = "Clothes";
            item.pic = "258";
            itemList.Add(item);

            item = new Items();
            item.name = "Pk kids Pack Of 3 - Baby Suit Unisex";
            item.price = 599;
            item.quantity = 5;
            item.color = "Multicolor";
            item.barcode = "KBBC0004";
            item.material = "Cotton";
            item.category = "Kids";
            item.category1 = "Baby";
            item.category2 = "Clothes";
            item.pic = "259";
            itemList.Add(item);

            item = new Items();
            item.name = "KHOUZH Pink Wool Booties For Baby Girls";
            item.price = 599;
            item.quantity = 15;
            item.color = "Pink";
            item.barcode = "KBBS0001";
            item.material = "Yarn and Wool";
            item.category = "Kids";
            item.category1 = "Baby";
            item.category2 = "Shoes";
            item.pic = "260";
            itemList.Add(item);

            item = new Items();
            item.name = "eCloud Pink Sandal shoes for loved kids Cute & lovely Girl";
            item.price = 399;
            item.quantity = 12;
            item.color = "Pink";
            item.barcode = "KBBS0002";
            item.material = "Fabric";
            item.category = "Kids";
            item.category1 = "Baby";
            item.category2 = "Shoes";
            item.pic = "261";
            itemList.Add(item);

            item = new Items();
            item.name = "MFB White Sandal shoes for loved kids Cute & lovely Girl";
            item.price = 320;
            item.quantity = 10;
            item.color = "White";
            item.barcode = "KBBS0003";
            item.material = "Fabric";
            item.category = "Kids";
            item.category1 = "Baby";
            item.category2 = "Shoes";
            item.pic = "262";
            itemList.Add(item);

            item = new Items();
            item.name = "Kit Kat Baby Baby Pack Of 2 - Bib For Babies";
            item.price = 199;
            item.quantity = 15;
            item.color = "Blue";
            item.barcode = "KBBA0001";
            item.material = "Cotton";
            item.category = "Kids";
            item.category1 = "Baby";
            item.category2 = "Accessories";
            item.pic = "263";
            itemList.Add(item);

            item = new Items();
            item.name = "BabyNest Boutique Baby head pillow- Round Pillow";
            item.price = 299;
            item.quantity = 12;
            item.color = "Pink";
            item.barcode = "KBBA0002";
            item.material = "Cotton";
            item.category = "Kids";
            item.category1 = "Baby";
            item.category2 = "Accessories";
            item.pic = "264";
            itemList.Add(item);

            item = new Items();
            item.name = "Hafiz Sports Pakistan Independent Day Special Headbands";
            item.price = 99;
            item.quantity = 9;
            item.color = "Green and White";
            item.barcode = "KBBA0003";
            item.material = "Cotton";
            item.category = "Kids";
            item.category1 = "Baby";
            item.category2 = "Accessories";
            item.pic = "265";
            itemList.Add(item);

            item = new Items();
            item.name = "China Baby Wraping Sheet ";
            item.price = 350;
            item.quantity = 8;
            item.color = "Pink";
            item.barcode = "KBBA0004";
            item.material = "Cotton";
            item.category = "Kids";
            item.category1 = "Baby";
            item.category2 = "Accessories";
            item.pic = "266";
            itemList.Add(item);

            item = new Items();
            item.name = "Amaze Collection Pink Cotton Embroidered Kurta for Girls - GS-212 ";
            item.price = 799;
            item.quantity = 8;
            item.color = "Pink";
            item.barcode = "KGCK0001";
            item.material = "Cotton";
            item.category = "Kids";
            item.category1 = "Girl";
            item.category2 = "Clothes";
            item.category3 = "Kurtas and Shalwar Kamiz";
            item.pic = "267";
            itemList.Add(item);

            item = new Items();
            item.name = "OCHRE Multicolour Mix Kurti With Dupatta For Women";
            item.price = 1425;
            item.quantity = 7;
            item.color = "Multicolor";
            item.barcode = "KGCK0002";
            item.material = "Mix";
            item.category = "Kids";
            item.category1 = "Girl";
            item.category2 = "Clothes";
            item.category3 = "Kurtas and Shalwar Kamiz";
            item.pic = "268";
            itemList.Add(item);

            item = new Items();
            item.name = "Wardrobe Desire Independence Day Girls Kurti And Trouser-14 August";
            item.price = 399;
            item.quantity = 8;
            item.color = "Green and White";
            item.barcode = "KGCK0003";
            item.material = "Linen";
            item.category = "Kids";
            item.category1 = "Girl";
            item.category2 = "Clothes";
            item.category3 = "Kurtas and Shalwar Kamiz";
            item.pic = "269";
            itemList.Add(item);

            item = new Items();
            item.name = "Kidz N Kidz Yellow Printed Poplin Cotton Frock For Girls";
            item.price = 1195;
            item.quantity = 4;
            item.color = "Yellow";
            item.barcode = "KGCF0001";
            item.material = "Cotton";
            item.category = "Kids";
            item.category1 = "Girl";
            item.category2 = "Clothes";
            item.category3 = "Frocks";
            item.pic = "270";
            itemList.Add(item);

            item = new Items();
            item.name = "Brands House White Original H&M Printed Sleeveless Frock For Girls";
            item.price = 749;
            item.quantity = 14;
            item.color = "White";
            item.barcode = "KGCF0002";
            item.material = "Cotton";
            item.category = "Kids";
            item.category1 = "Girl";
            item.category2 = "Clothes";
            item.category3 = "Frocks";
            item.pic = "271";
            itemList.Add(item);

            item = new Items();
            item.name = "Kinder Kollection 3 - 5 Year Girl Birthday Wedding Party Dress Blue Baby Girl Dress";
            item.price = 1600;
            item.quantity = 10;
            item.color = "Navy Blue";
            item.barcode = "KGCF0003";
            item.material = "Polyester and Viscose";
            item.category = "Kids";
            item.category1 = "Girl";
            item.category2 = "Clothes";
            item.category3 = "Frocks";
            item.pic = "272";
            itemList.Add(item); 
            
            item = new Items();
            item.name = "Fashion Café Light Pink Cotton Tights For Girls";
            item.price = 199;
            item.quantity = 11;
            item.color = "Light Pink";
            item.barcode = "KGCP0001";
            item.material = "Cotton";
            item.category = "Kids";
            item.category1 = "Girl";
            item.category2 = "Clothes";
            item.category3 = "Pants";
            item.pic = "273";
            itemList.Add(item);

            item = new Items();
            item.name = "Kidz N Kidz Off-White Polka Dot Plain Slub Pajama For Girls";
            item.price = 499;
            item.quantity = 10;
            item.color = "White";
            item.barcode = "KGCP0002";
            item.material = "Cotton";
            item.category = "Kids";
            item.category1 = "Girl";
            item.category2 = "Clothes";
            item.category3 = "Pants";
            item.pic = "274";
            itemList.Add(item);

            item = new Items();
            item.name = "Kids Creations Pack of 3 Lycra Plain Tights for Girls";
            item.price = 699;
            item.quantity = 5;
            item.color = "Multicolor";
            item.barcode = "KGCP0003";
            item.material = "Lycra";
            item.category = "Kids";
            item.category1 = "Girl";
            item.category2 = "Clothes";
            item.category3 = "Pants";
            item.pic = "275";
            itemList.Add(item);

            item = new Items();
            item.name = "Home Assembles Multi Color, Knit, Sweater Suit For Boys & Girls, 003";
            item.price = 750;
            item.quantity = 5;
            item.color = "Pink and White";
            item.barcode = "KGCW0001";
            item.material = "Knit and Wool";
            item.category = "Kids";
            item.category1 = "Girl";
            item.category2 = "Clothes";
            item.category3 = "Winter Wear";
            item.pic = "276";
            itemList.Add(item);

            item = new Items();
            item.name = "ABBY Maroon Printed Cotton Sweatshirt Unisex";
            item.price = 699;
            item.quantity = 15;
            item.color = "Maroon";
            item.barcode = "KGCW0002";
            item.material = "Cotton";
            item.category = "Kids";
            item.category1 = "Girl";
            item.category2 = "Clothes";
            item.category3 = "Winter Wear";
            item.pic = "277";
            itemList.Add(item);

            item = new Items();
            item.name = "Choices Online Store Frozen Pink Hoodie For Girls";
            item.price = 7150;
            item.quantity = 15;
            item.color = "Pink";
            item.barcode = "KGCW0003";
            item.material = "Wool and Ployester";
            item.category = "Kids";
            item.category1 = "Girl";
            item.category2 = "Clothes";
            item.category3 = "Winter Wear";
            item.pic = "278";
            itemList.Add(item);

        }

        private void ProductUC_Load(object sender, EventArgs e)
        {
            //homePanel.BringToFront();

            var paths = Directory.GetFiles("D:\\Pics").OrderBy(f => f.Length);
          //var paths = Directory.GetFiles("D:\\Pics").Select(f => new FileInfo(f)).OrderBy(f => f.FullName);   
            images.ImageSize = new Size(150,150);

                foreach (var path in paths)
                {
                    images.Images.Add(Image.FromFile(path.ToString()));
                }
            Data();     
          }

       

        private void kids_boysfashionBackbtn_Click(object sender, EventArgs e)
        {
            kidsfashionPanel.BringToFront();
        }

        private void kids_girls_clothesBackbtn_Click(object sender, EventArgs e)
        {
            kids_girlsfashionPanel.BringToFront();
        }

        private void kids_boys_clothesBackbtn_Click(object sender, EventArgs e)
        {
            kids_boysfashionPanel.BringToFront();
        }

        private void kids_girlsfashionBackbtn_Click(object sender, EventArgs e)
        {
            kidsfashionPanel.BringToFront();
        }

        

        

        

        

        

        private void pictureBox66_Click(object sender, EventArgs e)
        {
            kids_girls_clothesPanel.BringToFront();
        }

        private void label66_Click(object sender, EventArgs e)
        {
            kids_girls_clothesPanel.BringToFront();
        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {
            kids_boys_clothesPanel.BringToFront();
        }

        private void label55_Click(object sender, EventArgs e)
        {
            kids_boys_clothesPanel.BringToFront();
        }

        

        

        private void kids_babysfashionBackbtn_Click(object sender, EventArgs e)
        {
            kidsfashionPanel.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            homePanel.BringToFront();
        }
        #region womenfashion
        private void womensFashionpicBox_Click(object sender, EventArgs e)
        {
            womensFashionPanel.BringToFront();
        }

        private void womensFashionlbl_Click(object sender, EventArgs e)
        {
            womensFashionPanel.BringToFront();
        }

        private void womensFashionBackbtn_Click_1(object sender, EventArgs e)
        {
            homePanel.BringToFront();
        }
        #region women_pakistaniClothing
        private void women_Pakistanilbl_Click(object sender, EventArgs e)
        {
            women_pakistaniPanel.BringToFront();
        }

        private void women_PakistaniPicBox_Click(object sender, EventArgs e)
        {
            women_pakistaniPanel.BringToFront();
        }

        private void women_pakistaniBackbtn_Click(object sender, EventArgs e)
        {
            womensFashionPanel.BringToFront();
        }
        #region women_pakistani_AddItem
        void women_pakistani_Kurtas_AddItems()
        {
            int record=0;
            women_pakistani_KurtasListView.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Pakistani Clothing" && itemList[i].category2 == "Kurtas and Shalwar Kamiz")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_pakistani_KurtasListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_pakistani_KurtasListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_pakistani_Kurtas_recordslbl.Text="Total record = "+record;
        }
        
        void women_pakistani_Formal_AddItems()
        {
            int record = 0;
            women_pakistani_FormalListView.Items.Clear();
            women_pakistani_FormalListView.SmallImageList = images;


            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Pakistani Clothing" && itemList[i].category2 == "Formal Wear")
                {
                    ListViewItem itemListView = new ListViewItem();

                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_pakistani_FormalListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_pakistani_Formal_recordslbl.Text = "Total record = " + record;
        }

        void women_pakistani_Pants_AddItems()
        {
            int record=0;
            women_pakistani_pantsListView.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Pakistani Clothing" && itemList[i].category2 == "Pants and Plazzoes")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_pakistani_pantsListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_pakistani_pantsListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_pakistani_pants_recordslbl.Text = "Total record = " + record;
        }

        void women_pakistani_Abbayas_AddItems()
        {
            int record = 0;
            women_pakistani_abbayasListView.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Pakistani Clothing" && itemList[i].category2 == "Abbayas and Hijabs")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_pakistani_abbayasListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_pakistani_abbayasListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_pakistani_abbayas_recordslbl.Text = "Total record = " + record;
        }

        void women_pakistani_Dupattas_AddItems()
        {
            int record = 0;
            women_pakistani_dupattasListView.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Pakistani Clothing" && itemList[i].category2 == "Dupattas and Shawls")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_pakistani_dupattasListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_pakistani_dupattasListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_pakistani_dupattas_recordslbl.Text = "Total record = " + record;
        }
        #endregion

        #region women_pakistani_Kurtas
        private void women_pakistani_KurtasPicBox_Click_1(object sender, EventArgs e)
        {
            women_pakistani_KurtasPanel.BringToFront();
            women_pakistani_kurtasRefreshbtn.Visible = false;
            women_pakistani_Kurtas_Searchtxt.Clear();
            women_pakistani_Kurtas_AddItems();
        }
        private void women_pakistani_Kurtaslbl_Click(object sender, EventArgs e)
        {
            women_pakistani_KurtasPanel.BringToFront();
            women_pakistani_kurtasRefreshbtn.Visible = false;
            women_pakistani_Kurtas_Searchtxt.Clear();
            women_pakistani_Kurtas_AddItems();
        }
        private void women_pakistani_Kurtas_Searchbtn_Click(object sender, EventArgs e)
        {
            int secret=0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_pakistani_Kurtas_Searchtxt.Text == itemList[i].barcode && (itemList[i].category == "Women" && itemList[i].category1 == "Pakistani Clothing" && itemList[i].category2 == "Kurtas and Shalwar Kamiz"))
                {
                    women_pakistani_KurtasListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_pakistani_KurtasListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_pakistani_KurtasListView.Items.Add(itemListView);
                    women_pakistani_kurtasRefreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if(i==itemList.Count-1)
                    secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void women_pakistani_kurtasBackbtn_Click(object sender, EventArgs e)
        {
            women_pakistaniPanel.BringToFront();
        }
        private void women_pakistani_kurtasRefreshbtn_Click(object sender, EventArgs e)
        {
            women_pakistani_kurtasRefreshbtn.Visible = false;
            women_pakistani_Kurtas_Searchtxt.Clear();
            women_pakistani_Kurtas_AddItems();
        }
        #endregion

        #region women_pakistani_Formal
        private void women_pakistani_FormalPicBox_Click_1(object sender, EventArgs e)
        {
            women_pakistani_FormalPanel.BringToFront();
            women_pakistani_Formal_AddItems();
            women_pakistani_Formal_Refreshbtn.Visible = false;
            women_pakistani_Formal_searchtxt.Clear();
        }


        private void women_pakistani_Formallbl_Click(object sender, EventArgs e)
        {
            women_pakistani_FormalPanel.BringToFront();
            women_pakistani_Formal_AddItems();
            women_pakistani_Formal_Refreshbtn.Visible = false;
            women_pakistani_Formal_searchtxt.Clear();
        }

        private void women_pakistani_Formal_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_pakistani_Formal_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Pakistani Clothing" && itemList[i].category2 == "Formal Wear")
                {
                    women_pakistani_FormalListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_pakistani_FormalListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_pakistani_FormalListView.Items.Add(itemListView);
                    women_pakistani_Formal_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void women_pakistani_Formal_Backbtn_Click(object sender, EventArgs e)
        {
            women_pakistaniPanel.BringToFront();
        }

        private void women_pakistani_Formal_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_pakistani_Formal_Refreshbtn.Visible = false;
            women_pakistani_Formal_AddItems();
            women_pakistani_Formal_searchtxt.Clear();
        }
        #endregion

        #region women_pakistani_Pants
        private void women_pakistani_PantsPicBox_Click_1(object sender, EventArgs e)
        {
            women_pakistani_pantsPanel.BringToFront();
            women_pakistani_pants_Refreshbtn.Visible = false;
            women_pakistani_pants_Searchtxt.Clear();
            women_pakistani_Pants_AddItems();
        }

        private void women_pakistani_Pantslbl_Click(object sender, EventArgs e)
        {
            women_pakistani_pantsPanel.BringToFront();
            women_pakistani_pants_Refreshbtn.Visible = false;
            women_pakistani_pants_Searchtxt.Clear();
            women_pakistani_Pants_AddItems();
        }

        private void women_pakistani_pants_Searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_pakistani_pants_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Pakistani Clothing" && itemList[i].category2 == "Pants and Plazzoes")
                {
                    women_pakistani_pantsListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_pakistani_pantsListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_pakistani_pantsListView.Items.Add(itemListView);
                    women_pakistani_pants_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void women_pakistani_pants_Backbtn_Click(object sender, EventArgs e)
        {
            women_pakistaniPanel.BringToFront();
        }

        private void women_pakistani_pants_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_pakistani_pants_Backbtn.Visible = false;
            women_pakistani_pants_Searchtxt.Clear();
            women_pakistani_Pants_AddItems();
        }
        #endregion

        #region women_pakistani_Abbayas
        private void women_pakistani_AbbayasPicBox_Click_1(object sender, EventArgs e)
        {
            women_pakistani_abbayasPanel.BringToFront();
            women_pakistani_abbayas_Refreshbtn.Visible = false;
            women_pakistani_abbayas_Searchtxt.Clear();
            women_pakistani_Abbayas_AddItems();
        }

        private void women_pakistani_Abbayaslbl_Click(object sender, EventArgs e)
        {
            women_pakistani_abbayasPanel.BringToFront();
            women_pakistani_abbayas_Refreshbtn.Visible = false;
            women_pakistani_abbayas_Searchtxt.Clear();
            women_pakistani_Abbayas_AddItems();
        }

        private void women_pakistani_abbayas_Searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_pakistani_abbayas_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Pakistani Clothing" && itemList[i].category2 == "Abbayas and Hijabs")
                {
                    women_pakistani_abbayasListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_pakistani_abbayasListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_pakistani_abbayasListView.Items.Add(itemListView);
                    women_pakistani_abbayas_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void women_pakistani_abbayas_Backbtn_Click(object sender, EventArgs e)
        {
            women_pakistaniPanel.BringToFront();
        }

        private void women_pakistani_abbayas_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_pakistani_abbayas_Refreshbtn.Visible = false;
            women_pakistani_abbayas_Searchtxt.Clear();
            women_pakistani_Abbayas_AddItems();
        }
        #endregion

        #region women_pakistani_Dupattas
        private void women_pakistani_DupattasPicBox_Click_1(object sender, EventArgs e)
        {
            women_pakistani_dupattasPanel.BringToFront();
            women_pakistani_dupattas_Refreshbtn.Visible = false;
            women_pakistani_dupattas_Searchtxt.Clear();
            women_pakistani_Dupattas_AddItems();
        }

        private void women_pakistani_Dupattaslbl_Click(object sender, EventArgs e)
        {
            women_pakistani_dupattasPanel.BringToFront();
            women_pakistani_dupattas_Refreshbtn.Visible = false;
            women_pakistani_dupattas_Searchtxt.Clear();
            women_pakistani_Dupattas_AddItems();
        }

        private void women_pakistani_dupattas_Searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_pakistani_dupattas_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Pakistani Clothing" && itemList[i].category2 == "Dupattas and Shawls")
                {
                    women_pakistani_dupattasListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_pakistani_dupattasListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_pakistani_dupattasListView.Items.Add(itemListView);
                    women_pakistani_dupattas_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }  

        private void women_pakistani_dupattas_Backhbtn_Click(object sender, EventArgs e)
        {
            women_pakistaniPanel.BringToFront();
        }

        private void women_pakistani_dupattas_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_pakistani_dupattas_Refreshbtn.Visible = false;
            women_pakistani_dupattas_Searchtxt.Clear();
            women_pakistani_Dupattas_AddItems();
        }
        #endregion
        #endregion

        #region women_westernClothing
        private void women_WestrernPicBox_Click(object sender, EventArgs e)
        {
            women_westernPanel.BringToFront();
        }

        private void women_Westrenlbl_Click(object sender, EventArgs e)
        {
            women_westernPanel.BringToFront();
        }

        private void women_westernBackbtn_Click(object sender, EventArgs e)
        {
            womensFashionPanel.BringToFront();
        }
        #region women_western_AddItem
        void women_western_Tops_AddItem()
        {
            int record=0;
            women_western_TopsListView.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Westren Clothing" && itemList[i].category2 == "Tops and Shirts")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_western_TopsListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_western_TopsListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_western_Tops_recordslbl.Text = "Total record = " + record; 
        }

        void women_western_Tshirt_AddItem()
        {
            int record=0;
            women_western_TshirtListView.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Westren Clothing" && itemList[i].category2 == "T-Shirts")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_western_TshirtListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_western_TshirtListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_western_Tshirt_recordslbl.Text = "Total record = " + record; 
        }

        void women_western_Tights_AddItem()
        {
            int record=0;
            women_western_TightsListView.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Westren Clothing" && itemList[i].category2 == "Bottoms and Tights")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_western_TightsListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_western_TightsListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_western_Tights_recordslbl.Text = "Total record = " + record; 
        }

        void women_western_Jeans_AddItem()
        {
            int record = 0;
            women_western_JeansListView.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Westren Clothing" && itemList[i].category2 == "Jeans")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_western_JeansListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_western_JeansListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_western_Jeans_recordslbl.Text = "Total record = " + record; 
        }
        #endregion

        #region women_western_Tops
        private void women_western_TopsPicBox_Click(object sender, EventArgs e)
        {
            women_western_TopsPanel.BringToFront();
            women_western_Tops_Searchtxt.Clear();
            women_western_Tops_Refreshbtn.Visible = false;
            women_western_Tops_AddItem();

        }

        private void women_western_Topslbl_Click(object sender, EventArgs e)
        {
            women_western_TopsPanel.BringToFront();
            women_western_Tops_Searchtxt.Clear();
            women_western_Tops_Refreshbtn.Visible = false;
            women_western_Tops_AddItem();
        }

        private void women_western_Tops_Searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_western_Tops_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Westren Clothing" && itemList[i].category2 == "Tops and Shirts")
                {
                    women_western_TopsListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_western_TopsListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_western_TopsListView.Items.Add(itemListView);
                    women_western_Tops_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void women_western_Tops_Backbtn_Click(object sender, EventArgs e)
        {
            women_westernPanel.BringToFront();
        }

        private void women_western_Tops_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_western_Tops_Refreshbtn.Visible = false;
            women_western_Tops_Searchtxt.Clear();
            women_western_Tops_AddItem();
        }
        #endregion

        #region women_western_Tshirt
        private void women_western_TshirtPicBox_Click(object sender, EventArgs e)
        {
            women_western_TshirtPanel.BringToFront();
            women_western_Tshirt_Refreshbtn.Visible = false;
            women_western_Tshirt_Searchtxt.Clear();
            women_western_Tshirt_AddItem();
        }

        private void women_western_Tshirtlbl_Click(object sender, EventArgs e)
        {
            women_western_TshirtPanel.BringToFront();
            women_western_Tshirt_Refreshbtn.Visible = false;
            women_western_Tshirt_Searchtxt.Clear();
            women_western_Tshirt_AddItem();
        }

        private void women_western_Tshirt_Searchbtn_Click(object sender, EventArgs e)
        {

            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_western_Tshirt_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Westren Clothing" && itemList[i].category2 == "T-Shirts")
                {
                    women_western_TshirtListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_western_TshirtListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_western_TshirtListView.Items.Add(itemListView);
                    women_western_Tshirt_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void women_western_Tshirt_Backbtn_Click(object sender, EventArgs e)
        {
            women_westernPanel.BringToFront();
        }

        private void women_western_Tshirt_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_western_Tshirt_Refreshbtn.Visible = false;
            women_western_Tshirt_Searchtxt.Clear();
            women_western_Tshirt_AddItem();
        }
        #endregion

        #region women_western_Tights
        private void women_western_TightsPicBox_Click(object sender, EventArgs e)
        {
            women_western_TightsPanel.BringToFront();
            women_western_Tights_Refreshbtn.Visible = false;
            women_western_Tights_Searchtxt.Clear();
            women_western_Tights_AddItem(); 
        }

        private void women_western_Tightslbl_Click(object sender, EventArgs e)
        {
            women_western_TightsPanel.BringToFront();
            women_western_Tights_Refreshbtn.Visible = false;
            women_western_Tights_Searchtxt.Clear();
            women_western_Tights_AddItem();
        }

        private void women_western_Tights_Searchbtn_Click(object sender, EventArgs e)
        {

            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_western_Tights_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Westren Clothing" && itemList[i].category2 == "Bottoms and Tights")
                {
                    women_western_TightsListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_western_TightsListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_western_TightsListView.Items.Add(itemListView);
                    women_western_Tights_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void women_western_Tights_Backbtn_Click(object sender, EventArgs e)
        {
            women_westernPanel.BringToFront();
        }

        private void women_western_Tights_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_western_Tights_Refreshbtn.Visible = false;
            women_western_Tights_Searchtxt.Clear();
            women_western_Tights_AddItem();
        }
        #endregion

        #region women_western_Jeans
        private void women_western_JeansPicBox_Click(object sender, EventArgs e)
        {
            women_western_JeansPanel.BringToFront();
            women_western_Jeans_Refreshbtn.Visible = false;
            women_western_Jeans_Searchtxt.Clear();
            women_western_Jeans_AddItem();
        }

        private void women_western_Jeanslbl_Click(object sender, EventArgs e)
        {
            women_western_JeansPanel.BringToFront();
            women_western_Jeans_Refreshbtn.Visible = false;
            women_western_Jeans_Searchtxt.Clear();
            women_western_Jeans_AddItem();
        }

        private void women_western_Jeans_Searchbtn_Click(object sender, EventArgs e)
        {

            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_western_Jeans_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Westren Clothing" && itemList[i].category2 == "Jeans")
                {
                    women_western_JeansListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_western_JeansListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_western_JeansListView.Items.Add(itemListView);
                    women_western_Jeans_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void women_western_Jeans_Backbtn_Click(object sender, EventArgs e)
        {
            women_westernPanel.BringToFront();
        }

        private void women_western_Jeans_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_western_Jeans_Refreshbtn.Visible = false;
            women_western_Jeans_Searchtxt.Clear();
            women_western_Jeans_AddItem();
        }
        #endregion
        #endregion

        #region women_accessories
        private void women_Accessorieslbl_Click(object sender, EventArgs e)
        {
            women_accessoriesPanel.BringToFront();
        }

        private void women_AccessoriesPicBox_Click(object sender, EventArgs e)
        {
            women_accessoriesPanel.BringToFront();
        }

        private void women_accessoriesBackbtn_Click(object sender, EventArgs e)
        {
            womensFashionPanel.BringToFront();
        }

        #region women_accessories_AddItem
        void women_accessories_Eye_AddItem()
        {
            int record = 0;
            women_accessories_EyeListView.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Accessories" && itemList[i].category2 == "Eye Wear")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_accessories_EyeListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_accessories_EyeListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_accessories_Eye_recordslbl.Text = "Total record = " + record; 
        }

        void women_accessories_Bags_AddItem()
        {
            int record = 0;
            women_accessories_BagsListView.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Accessories" && itemList[i].category2 == "Bags")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_accessories_BagsListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_accessories_BagsListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_accessories_Bags_recordslbl.Text = "Total record = " + record; 

        }

        void women_accessories_Scarves_AddItem()
        {
            int record=0;
            women_accessories_ScarvesListView.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Accessories" && itemList[i].category2 == "Scarves and Mufflers")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_accessories_ScarvesListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_accessories_ScarvesListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_accessories_Scarves_recordslbl.Text = "Total record = " + record; 

        }

        void women_accessories_Jwellery_AddItem()
        {
            int record=0;
            women_accessories_JwelleryListView.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Accessories" && itemList[i].category2 == "Jwellery")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_accessories_JwelleryListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_accessories_JwelleryListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_accessories_Jwellery_recordslbl.Text = "Total record = " + record; 

        }
        #endregion

        #region women_accessories_Bags
        private void women_accessories_BagsPicBox_Click(object sender, EventArgs e)
        {
            women_accessories_BagsPianel.BringToFront();
            women_accessories_Bags_Refreshbtn.Visible = false;
            women_accessories_Bags_Searchtxt.Clear();
            women_accessories_Bags_AddItem();
        }

        private void women_accessories_Bagslbl_Click(object sender, EventArgs e)
        {
            women_accessories_BagsPianel.BringToFront();
            women_accessories_Bags_Refreshbtn.Visible = false;
            women_accessories_Bags_Searchtxt.Clear();
            women_accessories_Bags_AddItem();
        }

        private void women_accessories_Bags_Searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_accessories_Bags_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Accessories" && itemList[i].category2 == "Bags")
                {
                    women_accessories_BagsListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_accessories_BagsListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_accessories_BagsListView.Items.Add(itemListView);
                    women_accessories_Bags_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void women_accessories_Bags_Backbtn_Click_1(object sender, EventArgs e)
        {
            women_accessoriesPanel.BringToFront();
        }

        private void women_accessories_Bags_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_accessories_Bags_Refreshbtn.Visible = false;
            women_accessories_Bags_Searchtxt.Clear();
            women_accessories_Bags_AddItem();
        }
        #endregion

        #region women_accessories_Eye

        private void women_accessories_EyePicBox_Click(object sender, EventArgs e)
        {
            women_accessories_EyePanel.BringToFront();
            women_accessories_Eye_Refreshbtn.Visible = false;
            women_accessories_Eye_Searchtxt.Clear();
            women_accessories_Eye_AddItem();
        }

        private void women_accessories_Eyelbl_Click(object sender, EventArgs e)
        {
            women_accessories_EyePanel.BringToFront();
            women_accessories_Eye_Refreshbtn.Visible = false;
            women_accessories_Eye_Searchtxt.Clear();
            women_accessories_Eye_AddItem();
        }

        private void women_accessories_Eye_Backbtn_Click(object sender, EventArgs e)
        {
            women_accessoriesPanel.BringToFront();
        }

        private void women_accessories_Eye_Searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_accessories_Eye_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Accessories" && itemList[i].category2 == "Eye Wear")
                {
                    women_accessories_EyeListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_accessories_EyeListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_accessories_EyeListView.Items.Add(itemListView);
                    women_accessories_Eye_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void women_accessories_Eye_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_accessories_Eye_Refreshbtn.Visible = false;
            women_accessories_Eye_Searchtxt.Clear();
            women_accessories_Eye_AddItem();
        }
        #endregion

        #region women_accessories_Scarves
        private void women_accessories_ScarvesPicBox_Click(object sender, EventArgs e)
        {
            women_accessories_ScarvesPanel.BringToFront();
            women_accessories_Scarves_Refreshbtn.Visible = false;
            women_accessories_Scarves_Searchtxt.Clear();
            women_accessories_Scarves_AddItem();
        }

        private void women_accessories_Scarveslbl_Click(object sender, EventArgs e)
        {
            women_accessories_ScarvesPanel.BringToFront();
            women_accessories_Scarves_Refreshbtn.Visible = false;
            women_accessories_Scarves_Searchtxt.Clear();
            women_accessories_Scarves_AddItem();
        }

        private void women_accessories_Scarves_Backbtn_Click(object sender, EventArgs e)
        {
            women_accessoriesPanel.BringToFront();
        }

        private void women_accessories_Scarves_Searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_accessories_Scarves_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Accessories" && itemList[i].category2 == "Scarves and Mufflers")
                {
                    women_accessories_ScarvesListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_accessories_ScarvesListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_accessories_ScarvesListView.Items.Add(itemListView);
                    women_accessories_Scarves_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void women_accessories_Scarves_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_accessories_Scarves_Refreshbtn.Visible = false;
            women_accessories_Scarves_Searchtxt.Clear();
            women_accessories_Scarves_AddItem();
        }
        #endregion

        #region women_accessories_Jwellerya
        private void women_accessories_JwelleryaPicBox_Click(object sender, EventArgs e)
        {
            women_accessories_JwelleryPanel.BringToFront();
            women_accessories_Jwellery_Refreshbtn.Visible = false;
            women_accessories_Jwellery_Searchtxt.Clear();
            women_accessories_Jwellery_AddItem();
        }

        private void women_accessories_Jwelleryalbl_Click(object sender, EventArgs e)
        {
            women_accessories_JwelleryPanel.BringToFront();
            women_accessories_Jwellery_Refreshbtn.Visible = false;
            women_accessories_Jwellery_Searchtxt.Clear();
            women_accessories_Jwellery_AddItem();
        }

        private void women_accessories_Jwellerya_Backbtn_Click(object sender, EventArgs e)
        {
            women_accessoriesPanel.BringToFront();
        }

        private void women_accessories_Jwellerya_Searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_accessories_Jwellery_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Accessories" && itemList[i].category2 == "Jwellery")
                {
                    women_accessories_JwelleryListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_accessories_JwelleryListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_accessories_JwelleryListView.Items.Add(itemListView);
                    women_accessories_Jwellery_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void women_accessories_Jwellery_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_accessories_Jwellery_Refreshbtn.Visible = false;
            women_accessories_Jwellery_Searchtxt.Clear();
            women_accessories_Jwellery_AddItem();
        }
        #endregion
        #endregion

        #region women_winterWear
        private void women_WinterPicBox_Click_1(object sender, EventArgs e)
        {
            women_winterPanel.BringToFront();
        }

        private void women_Winterlbl_Click_1(object sender, EventArgs e)
        {
            women_winterPanel.BringToFront();
        }

        private void women_winter_Backbtn_Click(object sender, EventArgs e)
        {
            womensFashionPanel.BringToFront();
        }
        #region women_winter_AddItem
        void women_winter_Jackets_AddItem()
        {
            int record = 0;
            women_winter_JacketsListView.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Winter Wear" && itemList[i].category2 == "Jackets and Coats")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_winter_JacketsListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_winter_JacketsListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_winter_Jackets_recordslbl.Text = "Total record = " + record; 

        }

        void women_winter_Hoodies_AddItem()
        {
            int record = 0;
            women_winter_HoodiesListView.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Winter Wear" && itemList[i].category2 == "Hoodies")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_winter_HoodiesListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_winter_HoodiesListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_winter_Hoodies_recordslbl.Text = "Total record = " + record; 
        }
        #endregion

        #region women_winter_Jackets
        private void women_winter_JacketsPicBox_Click(object sender, EventArgs e)
        {
            women_winter_JacketsPanel.BringToFront();
            women_winter_Jackets_Refreshbtn.Visible = false;
            women_winter_Jackets_Searchtxt.Clear();
            women_winter_Jackets_AddItem();
        }

        private void women_winter_Jacketslbl_Click(object sender, EventArgs e)
        {
            women_winter_JacketsPanel.BringToFront();
            women_winter_Jackets_Refreshbtn.Visible = false;
            women_winter_Jackets_Searchtxt.Clear();
            women_winter_Jackets_AddItem();
        }

        private void women_winter_Jackets_Searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_winter_Jackets_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Winter Wear" && itemList[i].category2 == "Jackets and Coats")
                {
                    women_winter_JacketsListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_winter_JacketsListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_winter_JacketsListView.Items.Add(itemListView);
                    women_winter_Jackets_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void women_winter_jackets_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_winter_Jackets_Refreshbtn.Visible = false;
            women_winter_Jackets_Searchtxt.Clear();
            women_winter_Jackets_AddItem();
        }

        private void women_winter_Jackets_Backbtn_Click(object sender, EventArgs e)
        {
            women_winterPanel.BringToFront();
        }
        #endregion

        #region women_winter_Hoodies
        private void women_winter_HoodiesPicBox_Click(object sender, EventArgs e)
        {
            women_winter_HoodiesPanel.BringToFront();
            women_winter_Hoodies_Refreshbtn.Visible = false;
            women_winter_Hoodies_Searchtxt.Clear();
            women_winter_Hoodies_AddItem();
        }

        private void women_winter_Hoodieslbl_Click(object sender, EventArgs e)
        {
            women_winter_HoodiesPanel.BringToFront();
            women_winter_Hoodies_Refreshbtn.Visible = false;
            women_winter_Hoodies_Searchtxt.Clear();
            women_winter_Hoodies_AddItem();
        }

        private void women_winter_Hoodies_Backbtn_Click(object sender, EventArgs e)
        {
            women_winterPanel.BringToFront();
        }

        private void women_winter_Hoodies_Searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_winter_Jackets_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Winter Wear" && itemList[i].category2 == "Hoodies")
                {
                    women_winter_HoodiesListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_winter_HoodiesListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_winter_HoodiesListView.Items.Add(itemListView);
                    women_winter_Hoodies_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void women_winter_Hoodies_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_winter_Hoodies_Refreshbtn.Visible = false;
            women_winter_Hoodies_Searchtxt.Clear();
            women_winter_Hoodies_AddItem();
        }
        #endregion
        #endregion

        #region women_watches
        private void women_WatchesPicBox_Click_1(object sender, EventArgs e)
        {
            women_watchesPanel.BringToFront();
        }

        private void women_Watcheslbl_Click_1(object sender, EventArgs e)
        {
            women_watchesPanel.BringToFront();
        }

        private void women_watchesBackbtn_Click(object sender, EventArgs e)
        {
            womensFashionPanel.BringToFront();
        }
        #region women_watches_AddItem
        void women_watches_Analog_AddItem()
        {
            int record = 0;
            women_watches_AnalogListView.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Watches" && itemList[i].category2 == "Analog")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_watches_AnalogListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_watches_AnalogListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_watches_Analog_recordslbl.Text = "Total record = " + record; 
        }

        void women_watches_Digital_AddItem()
        {
            int record = 0;
            women_watches_DigitalListView.Items.Clear();
            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Watches" && itemList[i].category2 == "Digital")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_watches_DigitalListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_watches_DigitalListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_watches_Digital_recordslbl.Text = "Total record = " + record; 

        }

        void women_watches_Cornograph_AddItem()
        {
            int record = 0;
            women_watches_CornographListView.Items.Clear();
            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Watches" && itemList[i].category2 == "Cornograph")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_watches_CornographListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_watches_CornographListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_watches_Cornograph_recordslbl.Text = "Total record = " + record; 

        }

        void women_watches_Smart_AddItem()
        {
            int record = 0;
            women_watches_SmartListView.Items.Clear();
            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Watches" && itemList[i].category2 == "Smart")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_watches_SmartListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_watches_SmartListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_watches_Smart_recordslbl.Text = "Total record = " + record; 

        }
        #endregion

        #region women_watches_Smart
        private void women_watches_SmartPicBox_Click_1(object sender, EventArgs e)
        {
            women_watches_SmartPanel.BringToFront();
            women_watches_Smart_Refreshbtn.Visible = false;
            women_watches_Smart_Searchtxt.Clear();
            women_watches_Smart_AddItem();
        }

        private void women_watches_Smartlbl_Click_1(object sender, EventArgs e)
        {
            women_watches_SmartPanel.BringToFront();
            women_watches_Smart_Refreshbtn.Visible = false;
            women_watches_Smart_Searchtxt.Clear();
            women_watches_Smart_AddItem();
        }

        private void women_watches_Smart_Searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_watches_Smart_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Watches" && itemList[i].category2 == "Smart")
                {
                    women_watches_SmartListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_watches_SmartListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_watches_SmartListView.Items.Add(itemListView);
                    women_watches_Smart_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void women_watches_Smart_Backbtn_Click(object sender, EventArgs e)
        {
            women_watchesPanel.BringToFront();
        }

        private void women_watches_Smart_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_watches_Smart_Refreshbtn.Visible = false;
            women_watches_Smart_Searchtxt.Clear();
            women_watches_Smart_AddItem();
        }
         #endregion

        #region women_watches_Analog
        private void women_watches_AnalogPicBox_Click_1(object sender, EventArgs e)
        {
            women_watches_AnalogPanel.BringToFront();
            women_watches_Analog_Refreshbtn.Visible = false;
            women_watches_Analog_Searchtxt.Clear();
            women_watches_Analog_AddItem();
        }

        private void women_watches_Analoglbl_Click_1(object sender, EventArgs e)
        {
            women_watches_AnalogPanel.BringToFront();
            women_watches_Analog_Refreshbtn.Visible = false;
            women_watches_Analog_Searchtxt.Clear();
            women_watches_Analog_AddItem();
        }

        private void women_watches_Analog_Searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_watches_Analog_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Watches" && itemList[i].category2 == "Analog")
                {
                    women_watches_AnalogListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_watches_AnalogListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_watches_AnalogListView.Items.Add(itemListView);
                    women_watches_Analog_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void women_watches_Analog_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_watches_Analog_Refreshbtn.Visible = false;
            women_watches_Analog_Searchtxt.Clear();
            women_watches_Analog_AddItem();
        }

        private void women_watches_Analog_Backbtn_Click(object sender, EventArgs e)
        {
            women_watchesPanel.BringToFront();
        }
        #endregion

        #region women_watches_Cornograph
        private void women_watches_CornographPicBox_Click_1(object sender, EventArgs e)
        {
            women_watches_CornographPanel.BringToFront();
            women_watches_Cornograph_Refreshbtn.Visible = false;
            women_watches_Cornograph_Searchtxt.Clear();
            women_watches_Cornograph_AddItem();
        }

        private void women_watches_Cornographlbl_Click_1(object sender, EventArgs e)
        {
            women_watches_CornographPanel.BringToFront();
            women_watches_Cornograph_Refreshbtn.Visible = false;
            women_watches_Cornograph_Searchtxt.Clear();
            women_watches_Cornograph_AddItem();
        }

        private void women_watches_Cornograph_Searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_watches_Cornograph_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Watches" && itemList[i].category2 == "Cornograph")
                {
                    women_watches_CornographListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_watches_CornographListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_watches_CornographListView.Items.Add(itemListView);
                    women_watches_Cornograph_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void women_watches_Cornograph_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_watches_Cornograph_Refreshbtn.Visible = false;
            women_watches_Cornograph_Searchtxt.Clear();
            women_watches_Cornograph_AddItem();
        }

        private void women_watches_Cornograph_Backbtn_Click(object sender, EventArgs e)
        {
            women_watchesPanel.BringToFront();
        }
        #endregion

        #region women_watches_Digital
        private void women_watches_DigitalPicBox_Click_1(object sender, EventArgs e)
        {
            women_watches_DigitalPanel.BringToFront();
            women_watches_Digital_Refreshbtn.Visible = false;
            women_watches_Digital_Searchtxt.Clear();
            women_watches_Digital_AddItem();
        }

        private void women_watches_Digitallbl_Click(object sender, EventArgs e)
        {
            women_watches_DigitalPanel.BringToFront();
            women_watches_Digital_Refreshbtn.Visible = false;
            women_watches_Digital_Searchtxt.Clear();
            women_watches_Digital_AddItem();
        }

        private void women_watches_Digital_Searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_watches_Digital_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Watches" && itemList[i].category2 == "Digital")
                {
                    women_watches_DigitalListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_watches_DigitalListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_watches_DigitalListView.Items.Add(itemListView);
                    women_watches_Digital_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void women_watches_Digital_Backbtn_Click(object sender, EventArgs e)
        {
            women_watchesPanel.BringToFront();
        }

        private void women_watches_Digital_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_watches_Digital_Refreshbtn.Visible = false;
            women_watches_Digital_Searchtxt.Clear();
            women_watches_Digital_AddItem();
        }
        #endregion
        #endregion

        #region women_shoes
        private void women_ShoesPicBox_Click(object sender, EventArgs e)
        {
            women_shoesPanel.BringToFront();
        }

        private void women_Shoeslbl_Click(object sender, EventArgs e)
        {
            women_shoesPanel.BringToFront();
        }

        private void women_shoesBackbtn_Click(object sender, EventArgs e)
        {
            womensFashionPanel.BringToFront();
        }
        #region women_shoes_AddItem
        void women_shoes_Sandals_AddItem()
        {
            int record = 0;
            women_shoes_SandalsListView.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Shoes" && itemList[i].category2 == "Sandals")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_shoes_SandalsListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_shoes_SandalsListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_shoes_Sandals_recordslbl.Text = "Total record = " + record; 
        }

        void women_shoes_Slippers_AddItem()
        {
            int record = 0;
            women_shoes_SlippersListView.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Shoes" && itemList[i].category2 == "Slippers")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_shoes_SlippersListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_shoes_SlippersListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_shoes_Slippers_recordslbl.Text = "Total record = " + record; 
        }

        void women_shoes_Heels_AddItem()
        {
            int record = 0;
            women_shoes_HeelsListView.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Shoes" && itemList[i].category2 == "Heels")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_shoes_HeelsListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_shoes_HeelsListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_shoes_Heels_recordslbl.Text = "Total record = " + record; 

       }

        void women_shoes_Sneakers_AddItem()
        {
            int record = 0;
            women_shoes_SneakersListView.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Shoes" && itemList[i].category2 == "Sneakers")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_shoes_SneakersListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_shoes_SneakersListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_shoes_Sneakers_recordslbl.Text = "Total record = " + record; 

        }

        void women_shoes_Pumps_AddItem()
        {
            int record = 0;
            women_shoes_PumpsListView.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Shoes" && itemList[i].category2 == "Pumps")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_shoes_PumpsListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_shoes_PumpsListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_shoes_Pumps_recordslbl.Text = "Total record = " + record; 

        }

        void women_shoes_Khussa_AddItem()
        {
            int record = 0;
            women_shoes_KhussaListView.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Women" && itemList[i].category1 == "Shoes" && itemList[i].category2 == "Khussa")
                {
                    ListViewItem itemListView = new ListViewItem();
                    women_shoes_KhussaListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_shoes_KhussaListView.Items.Add(itemListView);
                    ++record;
                }
            }
            women_shoes_Khussa_recordslbl.Text = "Total record = " + record; 
        }
        #endregion

        #region women_shoes_Sandals
        private void women_shoes_SandalsPicBox_Click(object sender, EventArgs e)
        {
            women_shoes_SandalsPanel.BringToFront();
            women_shoes_Sandals_Refreshbtn.Visible = false;
            women_shoes_Sandals_Searchtxt.Clear();
            women_shoes_Sandals_AddItem();
        }

        private void women_shoes_Sandalslbl_Click(object sender, EventArgs e)
        {
            women_shoes_SandalsPanel.BringToFront();
            women_shoes_Sandals_Refreshbtn.Visible = false;
            women_shoes_Sandals_Searchtxt.Clear();
            women_shoes_Sandals_AddItem();
        }

        private void women_shoes_Sandals_Searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_shoes_Sandals_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Shoes" && itemList[i].category2 == "Sandals")
                {
                    women_shoes_SandalsListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_shoes_SandalsListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_shoes_SandalsListView.Items.Add(itemListView);
                    women_shoes_Sandals_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void women_shoes_Sandals_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_shoes_Sandals_Refreshbtn.Visible = false;
            women_shoes_Sandals_Searchtxt.Clear();
            women_shoes_Sandals_AddItem();
        }

        private void women_shoes_Sandals_Backbtn_Click(object sender, EventArgs e)
        {
            women_shoesPanel.BringToFront();
        }
        #endregion

        #region women_shoes_slippers
        private void women_shoes_SlippersPicBox_Click(object sender, EventArgs e)
        {
            women_shoes_SlippersPanel.BringToFront();
            women_shoes_Slippers_Refreshbtn.Visible = false;
            women_shoes_Slippers_Searchtxt.Clear();
            women_shoes_Slippers_AddItem();
        }

        private void women_shoes_Slipperslbl_Click(object sender, EventArgs e)
        {
            women_shoes_SlippersPanel.BringToFront();
            women_shoes_Slippers_Refreshbtn.Visible = false;
            women_shoes_Slippers_Searchtxt.Clear();
            women_shoes_Slippers_AddItem();
        }

        private void women_shoes_Slippers_Searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_shoes_Slippers_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Shoes" && itemList[i].category2 == "Slippers")
                {
                    women_shoes_SlippersListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_shoes_SlippersListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_shoes_SlippersListView.Items.Add(itemListView);
                    women_shoes_Slippers_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void women_shoes_Slippers_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_shoes_Slippers_Refreshbtn.Visible = false;
            women_shoes_Slippers_Searchtxt.Clear();
            women_shoes_Slippers_AddItem();
        }

        private void women_shoes_Slippers_Backbtn_Click(object sender, EventArgs e)
        {
            women_shoesPanel.BringToFront();
        }
        #endregion

        #region women_shoes_Khussa
        private void women_shoes_KhussaPicBox_Click(object sender, EventArgs e)
        {
            women_shoes_KhussaPanel.BringToFront();
            women_shoes_Khussa_Refreshbtn.Visible = false;
            women_shoes_Khussa_Searchtxt.Clear();
            women_shoes_Khussa_AddItem();
        }

        private void women_shoes_Khussalbl_Click(object sender, EventArgs e)
        {
            women_shoes_KhussaPanel.BringToFront();
            women_shoes_Khussa_Refreshbtn.Visible = false;
            women_shoes_Khussa_Searchtxt.Clear();
            women_shoes_Khussa_AddItem();
        }

        private void women_shoes_Khussa_Searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_shoes_Khussa_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Shoes" && itemList[i].category2 == "Khussa")
                {
                    women_shoes_KhussaListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_shoes_KhussaListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_shoes_KhussaListView.Items.Add(itemListView);
                    women_shoes_Khussa_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void women_shoes_Khussa_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_shoes_Khussa_Refreshbtn.Visible = false;
            women_shoes_Khussa_Searchtxt.Clear();
            women_shoes_Khussa_AddItem();
        }

        private void women_shoes_Khussa_Backbtn_Click(object sender, EventArgs e)
        {
            women_shoesPanel.BringToFront();
        }
        #endregion

        #region women_shoes_Heels
        private void women_shoes_HeelsPicBox_Click(object sender, EventArgs e)
        {
            women_shoes_HeelsPanel.BringToFront();
            women_shoes_Heels_Refreshbtn.Visible = false;
            women_shoes_Heels_Searchtxt.Clear();
            women_shoes_Heels_AddItem();
        }

        private void women_shoes_Heelslbl_Click(object sender, EventArgs e)
        {
            women_shoes_HeelsPanel.BringToFront();
            women_shoes_Heels_Refreshbtn.Visible = false;
            women_shoes_Heels_Searchtxt.Clear();
            women_shoes_Heels_AddItem();
        }

        private void women_shoes_Heels_Searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_shoes_Heels_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Shoes" && itemList[i].category2 == "Heels")
                {
                    women_shoes_HeelsListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_shoes_HeelsListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_shoes_HeelsListView.Items.Add(itemListView);
                    women_shoes_Heels_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void women_shoes_Heels_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_shoes_Heels_Refreshbtn.Visible = false;
            women_shoes_Heels_Searchtxt.Clear();
            women_shoes_Heels_AddItem();
        }

        private void women_shoes_Heels_Backbtn_Click(object sender, EventArgs e)
        {
            women_shoesPanel.BringToFront();
        }
        #endregion

        #region women_shoes_Pumps
        private void women_shoes_PumpsPicBox_Click(object sender, EventArgs e)
        {
            women_shoes_PumpsPanel.BringToFront();
            women_shoes_Pumps_Refreshbtn.Visible = false;
            women_shoes_Pumps_Searchtxt.Clear();
            women_shoes_Pumps_AddItem();
        }

        private void women_shoes_Pumpslbl_Click(object sender, EventArgs e)
        {
            women_shoes_PumpsPanel.BringToFront();
            women_shoes_Pumps_Refreshbtn.Visible = false;
            women_shoes_Pumps_Searchtxt.Clear();
            women_shoes_Pumps_AddItem();
        }

        private void women_shoes_Pumps_Searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_shoes_Pumps_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Shoes" && itemList[i].category2 == "Pumps")
                {
                    women_shoes_PumpsListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_shoes_HeelsListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_shoes_PumpsListView.Items.Add(itemListView);
                    women_shoes_Pumps_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void women_shoes_Pumps_Refreshtxt_Click(object sender, EventArgs e)
        {
            women_shoes_Pumps_Refreshbtn.Visible = false;
            women_shoes_Pumps_Searchtxt.Clear();
            women_shoes_Pumps_AddItem();
        }

        private void women_shoes_Pumps_Backbtn_Click(object sender, EventArgs e)
        {
            women_shoesPanel.BringToFront();
        }
        #endregion

        #region women_shoes_Sneakers
        private void women_shoes_SneakersPicBox_Click(object sender, EventArgs e)
        {
            women_shoes_SneakersPanel.BringToFront();
            women_shoes_Sneakers_Refreshbtn.Visible = false;
            women_shoes_Sneakers_Searchtxt.Clear();
            women_shoes_Sneakers_AddItem();
        }

        private void women_shoes_Sneakersslbl_Click(object sender, EventArgs e)
        {
            women_shoes_SneakersPanel.BringToFront();
            women_shoes_Sneakers_Refreshbtn.Visible = false;
            women_shoes_Sneakers_Searchtxt.Clear();
            women_shoes_Sneakers_AddItem();
        }

        private void women_shoes_Sneakers_Searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (women_shoes_Sneakers_Searchtxt.Text == itemList[i].barcode && itemList[i].category == "Women" && itemList[i].category1 == "Shoes" && itemList[i].category2 == "Sneakers")
                {
                    women_shoes_SneakersListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    women_shoes_SneakersListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    women_shoes_SneakersListView.Items.Add(itemListView);
                    women_shoes_Sneakers_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void women_shoes_Sneakers_Refreshbtn_Click(object sender, EventArgs e)
        {
            women_shoes_Sneakers_Refreshbtn.Visible = false;
            women_shoes_Sneakers_Searchtxt.Clear();
            women_shoes_Sneakers_AddItem();
        }

        private void women_shoes_Sneakers_Backbtn_Click(object sender, EventArgs e)
        {
            women_shoesPanel.BringToFront();
        }
        #endregion

        private void men_winterPanel_Paint(object sender, PaintEventArgs e)
        {

        }



        #endregion
        #endregion

        #region MenFashion
        private void mensFashionpicBox_Click_1(object sender, EventArgs e)
        {
            menFashionPanel.BringToFront();
        }

        private void mensFashionlbl_Click(object sender, EventArgs e)
        {
            menFashionPanel.BringToFront();
        }

        private void menFashionBackbtn_Click(object sender, EventArgs e)
        {
            homePanel.BringToFront();
        }
        #region men_pakistaniClothing
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            men_pakistaniPanel.BringToFront();
        }

        private void men_Pakistanilbl_Click(object sender, EventArgs e)
        {
            men_pakistaniPanel.BringToFront();
        }

        private void men_pakistani_Backbtn_Click(object sender, EventArgs e)
        {
            menFashionPanel.BringToFront();
        }

        #region men_pakistani_AddItem
        void men_pakistani_ShalwarKamiz_AddItem()
        {
            int record = 0;

            men_pakistani_shalwarkamizListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Pakistani Clothing" && itemList[i].category2 == "Shalwar Kamiz")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_pakistani_shalwarkamizListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_pakistani_shalwarkamizListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_pakistani_shalwarkamiz_recordlbl.Text = "Total record = " + record;
        }

        void men_pakistani_Kurtas_AddItem()
        {
            int record = 0;

            men_pakistani_kurtasListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Pakistani Clothing" && itemList[i].category2 == "Kurtas")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_pakistani_kurtasListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_pakistani_kurtasListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_pakistani_kurtas_recordlbl.Text = "Total record = " + record;
        }

        void men_pakistani_WaistCoat_AddItem()
        {
            int record = 0;

            men_pakistani_waistCoatListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Pakistani Clothing" && itemList[i].category2 == "WaistCoat")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_pakistani_waistCoatListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_pakistani_waistCoatListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_pakistani_waistCoat_recordlbl.Text = "Total record = " + record;
        }

        void men_pakistani_Unstiched_AddItem()
        {
            int record = 0;

            men_pakistani_unstichedListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Pakistani Clothing" && itemList[i].category2 == "Unstiched")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_pakistani_unstichedListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_pakistani_unstichedListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_pakistani_unstiched_recordlbl.Text = "Total record = " + record;
        }
        #endregion

        #region men_pakistani_shalwarkamiz
        private void men_pakistani_shalwarkamizPicBox_Click(object sender, EventArgs e)
        {
            men_pakistani_shalwarkamizPanel.BringToFront();
            men_pakistani_shalwarkamiz_searchtxt.Clear();
            men_pakistani_shalwarkamiz_refreshbtn.Visible = false;
            men_pakistani_ShalwarKamiz_AddItem();
        }

        private void men_pakistani_shalwarkamizlbl_Click(object sender, EventArgs e)
        {
            men_pakistani_shalwarkamizPanel.BringToFront();
            men_pakistani_shalwarkamiz_searchtxt.Clear();
            men_pakistani_shalwarkamiz_refreshbtn.Visible = false;
            men_pakistani_ShalwarKamiz_AddItem();
        }

        private void men_pakistani_shalwarkamiz_backbtn_Click(object sender, EventArgs e)
        {
            men_pakistaniPanel.BringToFront();
        }

        private void men_pakistani_shalwarkamiz_refreshbtn_Click(object sender, EventArgs e)
        {
            men_pakistani_shalwarkamiz_refreshbtn.Visible = false;
            men_pakistani_shalwarkamiz_searchtxt.Clear();
            men_pakistani_ShalwarKamiz_AddItem();
        }

        private void men_pakistani_shalwarkamiz_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_pakistani_shalwarkamiz_searchtxt.Text == "")
                men_pakistani_shalwarkamiz_searchtxtclearbtn.Visible = false;
            else
                men_pakistani_shalwarkamiz_searchtxtclearbtn.Visible = true;
        }

        private void men_pakistani_shalwarkamiz_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_pakistani_shalwarkamiz_searchtxt.Clear();
            men_pakistani_shalwarkamiz_searchtxtclearbtn.Visible = false;
        }

        private void men_pakistani_shalwarkamiz_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_pakistani_shalwarkamiz_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Pakistani Clothing" && itemList[i].category2 == "Kamiz Shalwar")
                {
                    men_pakistani_shalwarkamizListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_pakistani_shalwarkamizListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_pakistani_shalwarkamizListview.Items.Add(itemListView);
                    men_pakistani_shalwarkamiz_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion

        #region men_pakistani_kurtas
        private void men_pakistani_kurtasPicBox_Click(object sender, EventArgs e)
        {
            men_pakistani_kurtasPanel.BringToFront();
            men_pakistani_kurtas_searchtxt.Clear();
            men_pakistani_kurtas_refreshbtn.Visible = false;
            men_pakistani_Kurtas_AddItem();
        }

        private void men_pakistani_kurtaslbl_Click(object sender, EventArgs e)
        {
            men_pakistani_kurtasPanel.BringToFront();
            men_pakistani_kurtas_searchtxt.Clear();
            men_pakistani_kurtas_refreshbtn.Visible = false;
            men_pakistani_Kurtas_AddItem();
        }

        private void men_pakistani_kurtas_backbtn_Click(object sender, EventArgs e)
        {
            men_pakistaniPanel.BringToFront();
        }

        private void men_pakistani_kurtas_refreshbtn_Click(object sender, EventArgs e)
        {
            men_pakistani_kurtas_refreshbtn.Visible = false;
            men_pakistani_kurtas_searchtxt.Clear();
            men_pakistani_Kurtas_AddItem();
        }

        private void men_pakistani_kurtas_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_pakistani_kurtas_searchtxt.Text == "")
                men_pakistani_kurtas_searchtxtclearbtn.Visible = false;
            else
                men_pakistani_kurtas_searchtxtclearbtn.Visible = true;
        }

        private void men_pakistani_kurtas_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_pakistani_kurtas_searchtxt.Clear();
            men_pakistani_kurtas_searchtxtclearbtn.Visible = false;
        }

        private void men_pakistani_kurtas_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_pakistani_kurtas_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Pakistani Clothing" && itemList[i].category2 == "Kurtas")
                {
                    men_pakistani_kurtasListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_pakistani_kurtasListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_pakistani_kurtasListview.Items.Add(itemListView);
                    men_pakistani_kurtas_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion

        #region men_pakistani_waistcoat
        private void men_pakistani_waistCoatPicBox_Click(object sender, EventArgs e)
        {
            men_pakistani_waistCoatPanel.BringToFront();
            men_pakistani_waistCoat_searchtxt.Clear();
            men_pakistani_waistCoat_refreshbtn.Visible = false;
            men_pakistani_WaistCoat_AddItem();
        }

        private void men_pakistani_waistCoatlbl_Click(object sender, EventArgs e)
        {
            men_pakistani_waistCoatPanel.BringToFront();
            men_pakistani_waistCoat_searchtxt.Clear();
            men_pakistani_waistCoat_refreshbtn.Visible = false;
            men_pakistani_WaistCoat_AddItem();
        }
        private void men_pakistani_waistCoat_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_pakistani_waistCoat_searchtxt.Text == "")
                men_pakistani_waistCoat_searchtxtclearbtn.Visible = false;
            else
                men_pakistani_waistCoat_searchtxtclearbtn.Visible = true;
        }

        private void men_pakistani_waistCoat_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_pakistani_waistCoat_searchtxt.Clear();
            men_pakistani_waistCoat_searchtxtclearbtn.Visible = false;
        }

        private void men_pakistani_waistCoat_refreshbtn_Click(object sender, EventArgs e)
        {
            men_pakistani_waistCoat_refreshbtn.Visible = false;
            men_pakistani_waistCoat_searchtxt.Clear();
            men_pakistani_WaistCoat_AddItem();
        }

        private void men_pakistani_waistCoat_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_pakistani_waistCoat_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Pakistani Clothing" && itemList[i].category2 == "WaistCoat")
                {
                    men_pakistani_waistCoatListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_pakistani_waistCoatListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_pakistani_waistCoatListview.Items.Add(itemListView);
                    men_pakistani_waistCoat_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void men_pakistani_waistCoat_backbtn_Click(object sender, EventArgs e)
        {
            men_pakistaniPanel.BringToFront();
        }
        #endregion

        #region men_pakistani_unstiched
        private void men_pakistani_unstichedPicBox_Click(object sender, EventArgs e)
        {
            men_pakistani_unstichedPanel.BringToFront();
            men_pakistani_unstiched_searchtxt.Clear();
            men_pakistani_unstiched_refreshbtn.Visible = false;
            men_pakistani_Unstiched_AddItem();
        }

        private void men_pakistani_unstichedlbl_Click(object sender, EventArgs e)
        {
            men_pakistani_unstichedPanel.BringToFront();
            men_pakistani_unstiched_searchtxt.Clear();
            men_pakistani_unstiched_refreshbtn.Visible = false;
            men_pakistani_Unstiched_AddItem();
        }


        private void men_pakistani_unstiched_backbtn_Click(object sender, EventArgs e)
        {
            men_pakistaniPanel.BringToFront();
        }

        private void men_pakistani_unstiched_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_pakistani_unstiched_searchtxt.Text == "")
                men_pakistani_unstiched_searchtxtclearbtn.Visible = false;
            else
                men_pakistani_unstiched_searchtxtclearbtn.Visible = true;
        }

        private void men_pakistani_unstiched_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_pakistani_unstiched_searchtxt.Clear();
            men_pakistani_unstiched_searchtxtclearbtn.Visible = false;
        }

        private void men_pakistani_unstiched_refreshbtn_Click(object sender, EventArgs e)
        {
            men_pakistani_unstiched_refreshbtn.Visible = false;
            men_pakistani_unstiched_searchtxt.Clear();
            men_pakistani_Unstiched_AddItem();
        }

        private void men_pakistani_unstiched_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_pakistani_unstiched_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Pakistani Clothing" && itemList[i].category2 == "Unstiched")
                {
                    men_pakistani_unstichedListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_pakistani_unstichedListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_pakistani_unstichedListview.Items.Add(itemListView);
                    men_pakistani_unstiched_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion
        #endregion

        #region men_westrenClothing
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            men_westernPanel.BringToFront();
        }

        private void men_Westernlbl_Click(object sender, EventArgs e)
        {
            men_westernPanel.BringToFront();
        }

        private void man_westernPanel_Click(object sender, EventArgs e)
        {
            menFashionPanel.BringToFront();
        }
        #region men_western_AddItem
        void men_western_Tshirt_AddItem()
        {
            int record = 0;
            men_western_TshirtListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Westren Clothing" && itemList[i].category2 == "T-Shirts")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_western_TshirtListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_western_TshirtListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_western_Tshirt_recordlbl.Text = "Total record = " + record;
        }

        void men_western_Polo_AddItem()
        {
            int record = 0;
            men_western_poloListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Westren Clothing" && itemList[i].category2 == "Polo")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_western_poloListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_western_poloListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_western_polo_recordlbl.Text = "Total record = " + record;
        }

        void men_western_Shirts_AddItem()
        {
            int record = 0;
            men_western_shirtListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Westren Clothing" && itemList[i].category2 == "Tops and Shirts")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_western_shirtListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_western_shirtListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_western_shirt_recordlbl.Text = "Total record = " + record;
        }

        void men_western_Pants_AddItem()
        {
            int record = 0;
            men_western_pantsListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Westren Clothing" && itemList[i].category2 == "Trousers and Pants")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_western_pantsListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_western_pantsListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_western_pants_recordlbl.Text = "Total record = " + record;
        }

        void men_western_Shorts_AddItem()
        {
            int record = 0;
            men_western_ShortsListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Westren Clothing" && itemList[i].category2 == "Shorts")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_western_ShortsListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_western_ShortsListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_western_Shorts_recorrdlbl.Text = "Total record = " + record;
        }

        void men_western_Jeans_AddItem()
        {
            int record = 0;
            men_western_JeansListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Westren Clothing" && itemList[i].category2 == "Jeans")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_western_JeansListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_western_JeansListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_western_Jeans_recordlbl.Text = "Total record = " + record;
        }
        #endregion

        #region men_westren_Tshirt
        private void men_western_TshirtPicBox_Click(object sender, EventArgs e)
        {
            men_western_TshirtPanel.BringToFront();
            men_western_Tshirt_searchtxt.Clear();
            men_western_Tshirt_refreshbtn.Visible = false;
            men_western_Tshirt_AddItem();
        }

        private void men_western_Tshirtlbl_Click(object sender, EventArgs e)
        {
            men_western_TshirtPanel.BringToFront();
            men_western_Tshirt_searchtxt.Clear();
            men_western_Tshirt_refreshbtn.Visible = false;
            men_western_Tshirt_AddItem();
        }

        private void men_western_Tshirt_backbtn_Click(object sender, EventArgs e)
        {
            men_westernPanel.BringToFront();
        }

        private void men_western_Tshirt_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_western_Tshirt_searchtxt.Text == "")
                men_western_Tshirt_searchtxtclearbtn.Visible = false;
            else
                men_western_Tshirt_searchtxtclearbtn.Visible = true;
        }

        private void men_western_Tshirt_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_western_Tshirt_searchtxt.Clear();
            men_western_Tshirt_searchtxtclearbtn.Visible = false;
        }

        private void men_western_Tshirt_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_western_Tshirt_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Westren Clothing" && itemList[i].category2 == "T-shirts")
                {
                    men_western_TshirtListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_western_TshirtListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_western_TshirtListview.Items.Add(itemListView);
                    men_western_Tshirt_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void men_western_Tshirt_refreshbtn_Click(object sender, EventArgs e)
        {
            men_western_Tshirt_refreshbtn.Visible = false;
            men_western_Tshirt_searchtxt.Clear();
            men_western_Tshirt_AddItem();
        }
        #endregion

        #region men_westren_polo
        private void men_western_poloPicBox_Click(object sender, EventArgs e)
        {
            men_western_poloPanel.BringToFront();
            men_western_polo_searchtxt.Clear();
            men_western_polo_refreshbtn.Visible = false;
            men_western_Polo_AddItem();
        }

        private void men_western_pololbl_Click(object sender, EventArgs e)
        {
            men_western_poloPanel.BringToFront();
            men_western_polo_searchtxt.Clear();
            men_western_polo_refreshbtn.Visible = false;
            men_western_Polo_AddItem();
        }

        private void men_western_polo_backbtn_Click(object sender, EventArgs e)
        {
            men_westernPanel.BringToFront();
        }

        private void men_western_polo_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_western_polo_searchtxt.Text == "")
                men_western_polo_searchtxtclearbtn.Visible = false;
            else
                men_western_polo_searchtxtclearbtn.Visible = true;
        }

        private void men_western_polo_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_western_polo_searchtxt.Clear();
            men_western_polo_searchtxtclearbtn.Visible = false;
        }

        private void men_western_polo_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_western_polo_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Westren Clothing" && itemList[i].category2 == "Polo")
                {
                    men_western_poloListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_western_poloListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_western_poloListview.Items.Add(itemListView);
                    men_western_polo_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void men_western_polo_refreshbtn_Click(object sender, EventArgs e)
        {
            men_western_polo_refreshbtn.Visible = false;
            men_western_polo_searchtxt.Clear();
            men_western_Polo_AddItem();
        }
        #endregion

        #region men_westren_shirt
        private void men_western_shirtPicBox_Click(object sender, EventArgs e)
        {
            men_western_shirtPanel.BringToFront();
            men_western_shirt_searchtxt.Clear();
            men_western_shirt_refreshtxt.Visible = false;
            men_western_Shirts_AddItem();
        }

        private void men_western_Shirtslbl_Click(object sender, EventArgs e)
        {
            men_western_shirtPanel.BringToFront();
            men_western_shirt_searchtxt.Clear();
            men_western_shirt_refreshtxt.Visible = false;
            men_western_Shirts_AddItem();
        }

        private void men_western_shirt_backbtn_Click(object sender, EventArgs e)
        {
            men_westernPanel.BringToFront();
        }

        private void men_western_shirt_refreshtxt_Click(object sender, EventArgs e)
        {
            men_western_shirt_refreshtxt.Visible = false;
            men_western_shirt_searchtxt.Clear();
            men_western_Shirts_AddItem();
        }

        private void men_western_shirt_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_western_shirt_searchtxt.Clear();
            men_western_shirt_searchtxtclearbtn.Visible = false;
        }

        private void men_western_shirt_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_western_shirt_searchtxt.Text == "")
                men_western_shirt_searchtxtclearbtn.Visible = false;
            else
                men_western_shirt_searchtxtclearbtn.Visible = true;
        }

        private void men_western_shirt_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_western_shirt_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Westren Clothing" && itemList[i].category2 == "Tops and Shirts")
                {
                    men_western_shirtListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_western_shirtListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_western_shirtListview.Items.Add(itemListView);
                    men_western_shirt_refreshtxt.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion

        #region men_westren_pants
        private void men_western_pantsPicBox_Click(object sender, EventArgs e)
        {
            men_western_pantsPanel.BringToFront();
            men_western_pants_searchtxt.Clear();
            men_western_pants_refreshtxt.Visible = false;
            men_western_Pants_AddItem();
        }

        private void men_western_pantslbl_Click(object sender, EventArgs e)
        {
            men_western_pantsPanel.BringToFront();
            men_western_pantsPanel.BringToFront();
            men_western_pants_searchtxt.Clear();
            men_western_pants_refreshtxt.Visible = false;
            men_western_Pants_AddItem();
        }

        private void men_western_pants_backbtn_Click(object sender, EventArgs e)
        {
            men_westernPanel.BringToFront();
        }

        private void men_western_pants_refreshtxt_Click(object sender, EventArgs e)
        {
            men_western_pants_refreshtxt.Visible = false;
            men_western_pants_searchtxt.Clear();
            men_western_Pants_AddItem();
        }

        private void men_western_pants_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_western_pants_searchtxt.Clear();
            men_western_pants_searchtxtclearbtn.Visible = false;
        }

        private void men_western_pants_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_western_pants_searchtxt.Text == "")
                men_western_pants_searchtxtclearbtn.Visible = false;
            else
                men_western_pants_searchtxtclearbtn.Visible = true;
        }

        private void men_western_pants_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_western_pants_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Westren Clothing" && itemList[i].category2 == "Trousers and Pants")
                {
                    men_western_pantsListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_western_pantsListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_western_pantsListview.Items.Add(itemListView);
                    men_western_pants_refreshtxt.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion

        #region men_westren_jeans
        private void men_western_JeansPicBox_Click(object sender, EventArgs e)
        {
            men_western_JeansPanel.BringToFront();
            men_western_JeansPanel.BringToFront();
            men_western_Jeans_searchtxt.Clear();
            men_western_Jeans_refreshbtn.Visible = false;
            men_western_Jeans_AddItem();
        }

        private void men_western_Jeanslbl_Click(object sender, EventArgs e)
        {
            men_western_JeansPanel.BringToFront();
            men_western_JeansPanel.BringToFront();
            men_western_Jeans_searchtxt.Clear();
            men_western_Jeans_refreshbtn.Visible = false;
            men_western_Jeans_AddItem();
        }

        private void men_western_Jeans_backbtn_Click(object sender, EventArgs e)
        {
            men_westernPanel.BringToFront();
        }

        private void men_western_Jeans_refreshbtn_Click(object sender, EventArgs e)
        {
            men_western_Jeans_refreshbtn.Visible = false;
            men_western_Jeans_searchtxt.Clear();
            men_western_Jeans_AddItem();
        }

        private void men_western_Jeans_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_western_Jeans_searchtxt.Text == "")
                men_western_Jeans_searchtxtclearbtn.Visible = false;
            else
                men_western_Jeans_searchtxtclearbtn.Visible = true;
        }

        private void men_western_Jeans_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_western_Jeans_searchtxt.Clear();
            men_western_Jeans_searchtxtclearbtn.Visible = false;
        }

        private void men_western_Jeans_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_western_Jeans_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Westren Clothing" && itemList[i].category2 == "Jeans")
                {
                    men_western_JeansListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_western_JeansListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_western_JeansListview.Items.Add(itemListView);
                    men_western_Jeans_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion

        #region men_westren_shorts
        private void men_western_ShortsPicBox_Click(object sender, EventArgs e)
        {
            men_western_ShortsPanel.BringToFront();
            men_western_ShortsPanel.BringToFront();
            men_western_Shorts_searchtxt.Clear();
            men_western_Shorts_refreshbtn.Visible = false;
            men_western_Shorts_AddItem();
        }

        private void men_western_Shortslbl_Click(object sender, EventArgs e)
        {
            men_western_ShortsPanel.BringToFront();
            men_western_ShortsPanel.BringToFront();
            men_western_Shorts_searchtxt.Clear();
            men_western_Shorts_refreshbtn.Visible = false;
            men_western_Shorts_AddItem();
        }

        private void men_western_Shorts_backbtn_Click(object sender, EventArgs e)
        {
            men_westernPanel.BringToFront();
        }

        private void men_western_Shorts_refreshbtn_Click(object sender, EventArgs e)
        {
            men_western_Shorts_refreshbtn.Visible = false;
            men_western_Shorts_searchtxt.Clear();
            men_western_Shorts_AddItem();
        }

        private void men_western_Shorts_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_western_Shorts_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Westren Clothing" && itemList[i].category2 == "Shorts")
                {
                    men_western_ShortsListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_western_ShortsListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_western_ShortsListview.Items.Add(itemListView);
                    men_western_Shorts_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void men_western_Shorts_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_western_Shorts_searchtxt.Clear();
            men_western_Shorts_searchtxtclearbtn.Visible = false;
        }

        private void men_western_Shorts_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_western_Shorts_searchtxt.Text == "")
                men_western_Shorts_searchtxtclearbtn.Visible = false;
            else
                men_western_Shorts_searchtxtclearbtn.Visible = true;
        }
        #endregion


        #endregion

        #region men_accessories
        private void men_AccessoriesPicBox_Click(object sender, EventArgs e)
        {
            men_accessoriesPanel.BringToFront();
        }

        private void men_Accessorieslbl_Click(object sender, EventArgs e)
        {
            men_accessoriesPanel.BringToFront();
        }

        private void men_accessoriesBackbtn_Click(object sender, EventArgs e)
        {
            menFashionPanel.BringToFront();
        }
        #region men_accessories AddItem
        void men_accessories_Wallets_AddItem()
        {
            int record = 0;
            men_accessories_WalletsListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Accessories" && itemList[i].category2 == "Wallets and Cardholders")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_accessories_WalletsListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_accessories_WalletsListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_accessories_Wallets_recordlbl.Text = "Total record = " + record;
        }

        void men_accessories_Ties_AddItem()
        {
            int record = 0;
            men_accessories_TiesListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Accessories" && itemList[i].category2 == "Ties and Cufflins")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_accessories_TiesListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_accessories_TiesListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_accessories_Ties_recordlbl.Text = "Total record = " + record;
        }

        void men_accessories_EyeWear_AddItem()
        {
            int record = 0;
            men_accessories_EyeWearListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Accessories" && itemList[i].category2 == "Eye Wear")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_accessories_EyeWearListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_accessories_EyeWearListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_accessories_EyeWear_recordlbl.Text = "Total record = " + record;
        }

        void men_accessories_Bags_AddItem()
        {
            int record = 0;
            men_accessories_BagsListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Accessories" && itemList[i].category2 == "Bags")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_accessories_BagsListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_accessories_BagsListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_accessories_Bags_recordbl.Text = "Total record = " + record;
        }

        void men_accessories_Belts_AddItem()
        {
            int record = 0;
            men_accessories_BeltsListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Accessories" && itemList[i].category2 == "Belts")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_accessories_BeltsListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_accessories_BeltsListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_accessories_Belts_recordlbl.Text = "Total record = " + record;
        }

        void men_accessories_Caps_AddItem()
        {
            int record = 0;
            men_accessories_CapsListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Accessories" && itemList[i].category2 == "Caps and Gloves")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_accessories_CapsListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_accessories_CapsListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_accessories_Caps_recordlbl.Text = "Total record = " + record;
        }
        #endregion

        #region men_accessories_Wallets
        private void men_accessories_WalletsPicBox_Click_1(object sender, EventArgs e)
        {
            men_accessories_WalletsPanel.BringToFront();
            men_accessories_WalletsPanel_Seaarchtxt.Clear();
            men_accessories_WalletsPanel_Refreshhbtn.Visible = false;
            men_accessories_Wallets_AddItem();
        }
       

        private void men_accessories_Walletslbl_Click_1(object sender, EventArgs e)
        {
            men_accessories_WalletsPanel.BringToFront();
            men_accessories_WalletsPanel_Seaarchtxt.Clear();
            men_accessories_WalletsPanel_Refreshhbtn.Visible = false;
            men_accessories_Wallets_AddItem();
        }
        private void men_accessories_Wallets_backbtn_Click(object sender, EventArgs e)
        {
            men_accessoriesPanel.BringToFront();
        }

        private void men_accessories_WalletsPanel_Seaarchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_accessories_WalletsPanel_Seaarchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Accessories" && itemList[i].category2 == "Wallets and Cardholders")
                {
                    men_accessories_WalletsListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_accessories_WalletsListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_accessories_WalletsListview.Items.Add(itemListView);
                    women_western_Tops_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void men_accessories_WalletsPanel_Refreshhbtn_Click(object sender, EventArgs e)
        {
            men_accessories_WalletsPanel_Refreshhbtn.Visible = false;
            men_accessories_WalletsPanel_Seaarchtxt.Clear();
            men_accessories_Wallets_AddItem();
        }

        private void men_accessories_WalletsPanel_Seaarchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_accessories_WalletsPanel_Seaarchtxt.Text == "")
                men_accessories_WalletsPanel_Seaarchtxt_clearbtn.Visible = false;
            else
                men_accessories_WalletsPanel_Seaarchtxt_clearbtn.Visible = true;
        }

        private void men_accessories_WalletsPanel_Seaarchtxt_clearbtn_Click(object sender, EventArgs e)
        {
            men_accessories_WalletsPanel_Seaarchtxt.Clear();
            men_accessories_WalletsPanel_Seaarchtxt_clearbtn.Visible = false;
        }
        #endregion

        #region men_accessories_Ties
        private void men_accessories_TiesPicBox_Click_1(object sender, EventArgs e)
        {
            men_accessories_TiesPanel.BringToFront();
            men_accessories_Ties_searchtxt.Clear();
            men_accessories_Ties_refreshbtn.Visible = false;
            men_accessories_Ties_AddItem();
        }

        private void men_accessories_Tieslbl_Click_1(object sender, EventArgs e)
        {
            men_accessories_TiesPanel.BringToFront();
            men_accessories_Ties_searchtxt.Clear();
            men_accessories_Ties_refreshbtn.Visible = false;
            men_accessories_Ties_AddItem();
        }

        private void men_accessories_Ties_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_accessories_Ties_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Accessories" && itemList[i].category2 == "Ties and Cufflins")
                {
                    men_accessories_TiesListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_accessories_TiesListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_accessories_TiesListview.Items.Add(itemListView);
                    men_accessories_Ties_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void men_accessories_Ties_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_accessories_Ties_searchtxt.Clear();
            men_accessories_Ties_searchtxtclearbtn.Visible = false;
        }

        private void men_accessories_Ties_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_accessories_Ties_searchtxt.Text == "")
                men_accessories_Ties_searchtxtclearbtn.Visible = false;
            else
                men_accessories_Ties_searchtxtclearbtn.Visible = true;
        }

        private void men_accessories_Ties_refreshbtn_Click(object sender, EventArgs e)
        {
            men_accessories_Ties_refreshbtn.Visible = false;
            men_accessories_Ties_searchtxt.Clear();
            men_accessories_Ties_AddItem();
        }

        private void men_accessories_Ties_backbtn_Click(object sender, EventArgs e)
        {
            men_accessoriesPanel.BringToFront();
        }
        #endregion

        #region men_accessories_EyeWear
        private void men_accessories_EyeWearPicBox_Click_1(object sender, EventArgs e)
        {
            men_accessories_EyeWearPanel.BringToFront();
            men_accessories_EyeWear_searchtxt.Clear();
            men_accessories_EyeWear_refreshbtn.Visible = false;
            men_accessories_EyeWear_AddItem();
        }

        private void men_accessories_EyeWearlbl_Click_1(object sender, EventArgs e)
        {
            men_accessories_EyeWearPanel.BringToFront();
            men_accessories_EyeWear_searchtxt.Clear();
            men_accessories_EyeWear_refreshbtn.Visible = false;
            men_accessories_EyeWear_AddItem();
        }

        private void men_accessories_EyeWear_backbtn_Click(object sender, EventArgs e)
        {
            men_accessoriesPanel.BringToFront();
        }

        private void men_accessories_EyeWear_refreshbtn_Click(object sender, EventArgs e)
        {
            men_accessories_EyeWear_refreshbtn.Visible = false;
            men_accessories_EyeWear_searchtxt.Clear();
            men_accessories_EyeWear_AddItem();
        }

        private void men_accessories_EyeWear_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_accessories_EyeWear_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Accessories" && itemList[i].category2 == "Eye Wear")
                {
                    men_accessories_EyeWearListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_accessories_EyeWearListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_accessories_EyeWearListview.Items.Add(itemListView);
                    men_accessories_EyeWear_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void men_accessories_EyeWear_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_accessories_EyeWear_searchtxt.Clear();
            men_accessories_EyeWear_searchtxtclearbtn.Visible = false;
        }

        private void men_accessories_EyeWear_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_accessories_EyeWear_searchtxt.Text == "")
                men_accessories_EyeWear_searchtxtclearbtn.Visible = false;
            else
                men_accessories_EyeWear_searchtxtclearbtn.Visible = true;
        }
        #endregion

        #region men_accessories_Bags
        private void men_accessories_BagsPicBox_Click_1(object sender, EventArgs e)
        {
            men_accessories_BagsPanel.BringToFront();
            men_accessories_Bags_searchtxt.Clear();
            men_accessories_Bags_refreshbtn.Visible = false;
            men_accessories_Bags_AddItem();
        }

        private void men_accessories_Bagslbl_Click_1(object sender, EventArgs e)
        {
            men_accessories_BagsPanel.BringToFront();
            men_accessories_Bags_searchtxt.Clear();
            men_accessories_Bags_refreshbtn.Visible = false;
            men_accessories_Bags_AddItem();
        }

        private void men_accessories_Bags_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_accessories_Bags_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Accessories" && itemList[i].category2 == "Bags")
                {
                    men_accessories_BagsListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_accessories_BagsListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_accessories_BagsListview.Items.Add(itemListView);
                    men_accessories_Bags_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void men_accessories_Bags_refreshbtn_Click(object sender, EventArgs e)
        {
            men_accessories_Bags_refreshbtn.Visible = false;
            men_accessories_Bags_searchtxt.Clear();
            men_accessories_Bags_AddItem();
        }

        private void men_accessories_Bags_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_accessories_Bags_searchtxt.Text == "")
                men_accessories_Bags_searchtxtclearbtn.Visible = false;
            else
                men_accessories_Bags_searchtxtclearbtn.Visible = true;
        }

        private void men_accessories_Bags_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_accessories_Bags_searchtxt.Clear();
            men_accessories_Bags_searchtxtclearbtn.Visible = false;
        }

        private void men_accessories_Bags_backbtn_Click(object sender, EventArgs e)
        {
            men_accessoriesPanel.BringToFront();
        }
        #endregion

        #region men_accessories_Belts
        private void men_accessories_Belts_backbtn_Click(object sender, EventArgs e)
        {
            men_accessoriesPanel.BringToFront();
        }

        private void men_accessories_BeltsPicBox_Click_1(object sender, EventArgs e)
        {
            men_accessories_BeltsPanel.BringToFront();
            men_accessories_Belts_searchtxt.Clear();
            men_accessories_Belts_refreshbtn.Visible = false;
            men_accessories_Belts_AddItem();
        }

        private void men_accessories_Beltslbl_Click_1(object sender, EventArgs e)
        {
            men_accessories_BeltsPanel.BringToFront();
            men_accessories_Belts_searchtxt.Clear();
            men_accessories_Belts_refreshbtn.Visible = false;
            men_accessories_Belts_AddItem();
        }

        private void men_accessories_Belts_refreshbtn_Click(object sender, EventArgs e)
        {
            men_accessories_Belts_refreshbtn.Visible = false;
            men_accessories_Belts_searchtxt.Clear();
            men_accessories_Belts_AddItem();
        }

        private void men_accessories_Belts_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_accessories_Belts_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Accessories" && itemList[i].category2 == "Belts")
                {
                    men_accessories_BeltsListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_accessories_BeltsListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_accessories_BeltsListview.Items.Add(itemListView);
                    men_accessories_Belts_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void men_accessories_Belts_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_accessories_Belts_searchtxt.Clear();
            men_accessories_Belts_searchtxtclearbtn.Visible = false;
        }

        private void men_accessories_Belts_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_accessories_Belts_searchtxt.Text == "")
                men_accessories_Belts_searchtxtclearbtn.Visible = false;
            else
                men_accessories_Belts_searchtxtclearbtn.Visible = true;
        }
        #endregion

        #region men_accessories_Caps
        private void men_accessories_CapsPicBox_Click_1(object sender, EventArgs e)
        {
            men_accessories_BeltsPanel.BringToFront();
            men_accessories_Belts_searchtxt.Clear();
            men_accessories_Belts_refreshbtn.Visible = false;
            men_accessories_Belts_AddItem();

        }

        private void men_accessories_Capslbl_Click_1(object sender, EventArgs e)
        {
            men_accessories_BeltsPanel.BringToFront();
            men_accessories_Belts_searchtxt.Clear();
            men_accessories_Belts_refreshbtn.Visible = false;
            men_accessories_Belts_AddItem();
        }
        private void men_accessories_Caps_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_accessories_Belts_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Accessories" && itemList[i].category2 == "Caps and Gloves")
                {
                    men_accessories_CapsListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_accessories_CapsListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_accessories_CapsListview.Items.Add(itemListView);
                    men_accessories_Caps_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void men_accessories_Caps_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_accessories_Caps_searchtxt.Text == "")
                men_accessories_Caps_searchtxtclearbtn.Visible = false;
            else
                men_accessories_Caps_searchtxtclearbtn.Visible = true;
        }

        private void men_accessories_Caps_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_accessories_Caps_searchtxt.Clear();
            men_accessories_Caps_searchtxtclearbtn.Visible = false;
        }

        private void men_accessories_Caps_Backbtn_Click(object sender, EventArgs e)
        {
            men_accessoriesPanel.BringToFront();
        }

        private void men_accessories_Caps_refreshbtn_Click(object sender, EventArgs e)
        {
            men_accessories_Caps_refreshbtn.Visible = false;
            men_accessories_Caps_searchtxt.Clear();
            men_accessories_Caps_AddItem();
        }
        #endregion
        #endregion

        #region men_Watches
        private void men_WatchesPicBox_Click(object sender, EventArgs e)
        {
            men_WatchesPanel.BringToFront();
        }

        private void men_Watcheslbl_Click(object sender, EventArgs e)
        {
            men_WatchesPanel.BringToFront();
        }

        private void men_WatchesBackbtn_Click(object sender, EventArgs e)
        {
            menFashionPanel.BringToFront();
        }
        #region men_watches_AddItem
        void men_watches_Smart_AddItem()
        {
            int record = 0;
            men_Watches_smartListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Watches" && itemList[i].category2 == "Smart")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_Watches_smartListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_Watches_smartListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_Watches_smart_recordlbl.Text = "Total record = " + record;
        }

        void men_watches_Analog_AddItem()
        {
            int record = 0;
            men_Watches_analogListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Watches" && itemList[i].category2 == "Analog")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_Watches_analogListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_Watches_analogListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_Watches_analog_recordlbl.Text = "Total record = " + record;
        }

        void men_watches_Cornograph_AddItem()
        {
            int record = 0;
            men_Watches_cornographListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Watches" && itemList[i].category2 == "Cornograph")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_Watches_cornographListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_Watches_cornographListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_Watches_cornograph_recrdlbl.Text = "Total record = " + record;
        }

        void men_watches_Digital_AddItem()
        {
            int record = 0;
            men_Watches_digitalListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Watches" && itemList[i].category2 == "Digital")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_Watches_digitalListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_Watches_digitalListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_Watches_recordlbl.Text = "Total record = " + record;
        }
        #endregion

        #region men_Watches_Smart
        private void men_Watches_smartPicBox_Click(object sender, EventArgs e)
        {
            men_Watches_smartPanel.BringToFront();
            men_Watches_smart_searchtxt.Clear();
            men_Watches_smart_refreshbtn.Visible = false;
            men_watches_Smart_AddItem();
        }
        private void men_Watches_smartlbl_Click(object sender, EventArgs e)
        {
            men_Watches_smartPanel.BringToFront();
            men_Watches_smart_searchtxt.Clear();
            men_Watches_smart_refreshbtn.Visible = false;
            men_watches_Smart_AddItem();
        }
        private void men_Watches_smart_backbtn_Click(object sender, EventArgs e)
        {
            men_WatchesPanel.BringToFront();
        }
        private void men_Watches_smart_refreshbtn_Click(object sender, EventArgs e)
        {
            men_Watches_smart_refreshbtn.Visible = false;
            men_Watches_smart_searchtxt.Clear();
            men_watches_Smart_AddItem();
        }

        private void men_Watches_smart_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_Watches_smart_searchtxt.Text == "")
                men_Watches_smart_searchtxtclearbtn.Visible = false;
            else
                men_Watches_smart_searchtxtclearbtn.Visible = true;
        }

        private void men_Watches_smart_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_Watches_smart_searchtxt.Clear();
            men_Watches_smart_searchtxtclearbtn.Visible = false;
        }

        private void men_Watches_smart_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_Watches_smart_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Watches" && itemList[i].category2 == "Smart")
                {
                    men_Watches_smartListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_Watches_smartListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_Watches_smartListview.Items.Add(itemListView);
                    men_Watches_smart_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion

        #region men_Watches_Analog
        private void men_Watches_analogPicBox_Click(object sender, EventArgs e)
        {
            men_Watches_analogPanel.BringToFront();
            men_Watches_analog_searchtxt.Clear();
            men_Watches_analog_refreshbtn.Visible = false;
            men_watches_Analog_AddItem();
        }

        private void men_Watches_analoglbl_Click(object sender, EventArgs e)
        {
            men_Watches_analogPanel.BringToFront();
            men_Watches_analog_searchtxt.Clear();
            men_Watches_analog_refreshbtn.Visible = false;
            men_watches_Analog_AddItem();
        }

        private void men_Watches_analog_backbtn_Click(object sender, EventArgs e)
        {
            men_WatchesPanel.BringToFront();
        }

        private void men_Watches_analog_refreshbtn_Click(object sender, EventArgs e)
        {
            men_Watches_analog_refreshbtn.Visible = false;
            men_Watches_analog_searchtxt.Clear();
            men_watches_Analog_AddItem();
        }

        private void men_Watches_analog_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_Watches_analog_searchtxt.Text == "")
                men_Watches_analog_searchtxtclearbtn.Visible = false;
            else
                men_Watches_analog_searchtxtclearbtn.Visible = true;
        }

        private void men_Watches_analog_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_Watches_analog_searchtxt.Clear();
            men_Watches_analog_searchtxtclearbtn.Visible = false;
        }

        private void men_Watches_analog_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_Watches_analog_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Watches" && itemList[i].category2 == "Analog")
                {
                    men_Watches_analogListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_Watches_analogListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_Watches_analogListview.Items.Add(itemListView);
                    men_Watches_analog_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion

        #region men_watches_cornograph
        private void men_Watches_cornographPicBox_Click(object sender, EventArgs e)
        {
            men_Watches_cornographPanel.BringToFront();
            men_Watches_cornograph_searchtxt.Clear();
            men_Watches_cornograph_refreshbtn.Visible = false;
            men_watches_Cornograph_AddItem();
        }

        private void men_Watches_cornographlbl_Click(object sender, EventArgs e)
        {
            men_Watches_cornographPanel.BringToFront();
            men_Watches_cornograph_searchtxt.Clear();
            men_Watches_cornograph_refreshbtn.Visible = false;
            men_watches_Cornograph_AddItem();
        }

        private void men_Watches_cornograph_refreshbtn_Click(object sender, EventArgs e)
        {
            men_Watches_cornograph_refreshbtn.Visible = false;
            men_Watches_cornograph_searchtxt.Clear();
            men_watches_Cornograph_AddItem();
        }

        private void men_Watches_cornograph_backbtn_Click(object sender, EventArgs e)
        {
            men_WatchesPanel.BringToFront();
        }

        private void men_Watches_cornograph_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_Watches_cornograph_searchtxt.Clear();
            men_Watches_cornograph_searchtxtclearbtn.Visible = false;
        }

        private void men_Watches_cornograph_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_Watches_cornograph_searchtxt.Text == "")
                men_Watches_cornograph_searchtxtclearbtn.Visible = false;
            else
                men_Watches_cornograph_searchtxtclearbtn.Visible = true;
        }

        private void men_Watches_cornograph_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_Watches_cornograph_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Watches" && itemList[i].category2 == "Cornograph")
                {
                    men_Watches_cornographListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_Watches_cornographListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_Watches_cornographListview.Items.Add(itemListView);
                    men_Watches_cornograph_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion

        #region men_watches_digital
        private void men_Watches_digitalPicBox_Click(object sender, EventArgs e)
        {
            men_Watches_digitalPanel.BringToFront();
            men_Watches_digital_searchtxt.Clear();
            men_Watches_digital_refreshbtn.Visible = false;
            men_watches_Digital_AddItem();
        }

        private void men_Watches_digitallbl_Click(object sender, EventArgs e)
        {
            men_Watches_digitalPanel.BringToFront();
            men_Watches_digital_searchtxt.Clear();
            men_Watches_digital_refreshbtn.Visible = false;
            men_watches_Digital_AddItem();
        }

        private void men_Watches_digital_backbtn_Click(object sender, EventArgs e)
        {
            men_WatchesPanel.BringToFront();
        }

        private void men_Watches_digital_refreshbtn_Click(object sender, EventArgs e)
        {
            men_Watches_digital_refreshbtn.Visible = false;
            men_Watches_digital_searchtxt.Clear();
            men_watches_Digital_AddItem();
        }

        private void men_Watches_digital_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_Watches_digital_searchtxt.Text == "")
                men_Watches_digital_searchtxtclearbtn.Visible = false;
            else
                men_Watches_digital_searchtxtclearbtn.Visible = true;
        }

        private void men_Watches_digital_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_Watches_digital_searchtxt.Clear();
            men_Watches_digital_searchtxtclearbtn.Visible = false;
        }

        private void men_Watches_digital_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_Watches_digital_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Watches" && itemList[i].category2 == "Digital")
                {
                    men_Watches_digitalListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_Watches_digitalListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_Watches_digitalListview.Items.Add(itemListView);
                    men_Watches_digital_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion
        #endregion

        #region men_shoes
        private void men_ShoesPicBox_Click(object sender, EventArgs e)
        {
            men_ShoesPanel.BringToFront();
        }

        private void men_Shoeslbl_Click(object sender, EventArgs e)
        {
            men_ShoesPanel.BringToFront();
        }

        private void men_ShoesBackbtn_Click(object sender, EventArgs e)
        {
            menFashionPanel.BringToFront();
        }
        #region men_shoes_AddItem
        void men_shoes_Sandals_AddItem()
        {
            int record = 0;
            men_Shoes_sandalsListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Shoes" && itemList[i].category2 == "Sandals and Slippers")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_Shoes_sandalsListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_Shoes_sandalsListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_Shoes_sandals_recordlbl.Text = "Total record = " + record;
        }

        void men_shoes_Casual_AddItem()
        {
            int record = 0;
            men_Shoes_casualListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Shoes" && itemList[i].category2 == "Casual Shoes")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_Shoes_casualListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_Shoes_casualListview.Items.Add(itemListView);
                    ++record;
                }
            }

            men_Shoes_casual_recordlbl.Text = "Total record = " + record;
        }

        void men_shoes_Formal_AddItem()
        {
            int record = 0;

            men_Shoes_formallListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Shoes" && itemList[i].category2 == "Formal Shoes")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_Shoes_formallListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_Shoes_formallListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_Shoes_formal_recordlbl.Text = "Total record = " + record;
        }

        void men_shoes_Sneakers_AddItem()
        {
            int record = 0;
            men_Shoes_sneakerslListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Shoes" && itemList[i].category2 == "Sneakers")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_Shoes_sneakerslListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_Shoes_sneakerslListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_Shoes_sneakersl_recordlbl.Text = "Total record = " + record;
        }

        void men_shoes_Boots_AddItem()
        {
            int record = 0;
            men_Shoes_bootsListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Shoes" && itemList[i].category2 == "Boots")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_Shoes_bootsListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_Shoes_bootsListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_Shoes_bootsl_recordlbl.Text = "Total record = " + record;
        }
        #endregion

        #region men_shoes_sandals
        private void men_Shoes_sandalsPicBox_Click(object sender, EventArgs e)
        {
            men_Shoes_sandalsPanel.BringToFront();
            men_Shoes_sandals_searchtxt.Clear();
            men_Shoes_sandals_refreshbtn.Visible = false;
            men_shoes_Sandals_AddItem();
        }

        private void men_Shoes_sandalslbl_Click(object sender, EventArgs e)
        {
            men_Shoes_sandalsPanel.BringToFront();
            men_Shoes_sandals_searchtxt.Clear();
            men_Shoes_sandals_refreshbtn.Visible = false;
            men_shoes_Sandals_AddItem();
        }

        private void men_Shoes_sandals_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_Shoes_sandals_searchtxt.Text == "")
                men_Shoes_sandals_searchtxtclearbtn.Visible = false;
            else
                men_Shoes_sandals_searchtxtclearbtn.Visible = true;
        }

        private void men_Shoes_sandals_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_Shoes_sandals_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Shoes" && itemList[i].category2 == "Sandals")
                {
                    men_Shoes_sandalsListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_Shoes_sandalsListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_Shoes_sandalsListview.Items.Add(itemListView);
                    men_Shoes_sandals_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void men_Shoes_sandals_refreshbtn_Click(object sender, EventArgs e)
        {
            men_Shoes_sandals_refreshbtn.Visible = false;
            men_Shoes_sandals_searchtxt.Clear();
            men_shoes_Sandals_AddItem();
        }

        private void men_Shoes_sandals_backbtn_Click(object sender, EventArgs e)
        {
            men_ShoesPanel.BringToFront();
        }

        private void men_Shoes_sandals_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_Shoes_sandals_searchtxt.Clear();
            men_Shoes_sandals_searchtxtclearbtn.Visible = false;
        }
        #endregion

        #region men_shoes_formal
        private void men_Shoes_formalalPicBox_Click(object sender, EventArgs e)
        {
            men_Shoes_formallPanel.BringToFront();
            men_Shoes_formal_searchtxt.Clear();
            men_Shoes_formal_refreshbtn.Visible = false;
            men_shoes_Formal_AddItem();
        }

        private void men_Shoes_formalallbl_Click(object sender, EventArgs e)
        {
            men_Shoes_formallPanel.BringToFront();
            men_Shoes_formal_searchtxt.Clear();
            men_Shoes_formal_refreshbtn.Visible = false;
            men_shoes_Formal_AddItem();
        }

        private void men_Shoes_formal_backbtn_Click(object sender, EventArgs e)
        {
            men_ShoesPanel.BringToFront();
        }

        private void men_Shoes_formal_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_Shoes_formal_searchtxt.Text == "")
                men_Shoes_formal_searchtxtclearbtn.Visible = false;
            else
                men_Shoes_formal_searchtxtclearbtn.Visible = true;
        }

        private void men_Shoes_formal_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_Shoes_formal_searchtxt.Clear();
            men_Shoes_formal_searchtxtclearbtn.Visible = false;
        }

        private void men_Shoes_formal_refreshbtn_Click(object sender, EventArgs e)
        {
            men_Shoes_formal_refreshbtn.Visible = false;
            men_Shoes_formal_searchtxt.Clear();
            men_shoes_Formal_AddItem();
        }

        private void men_Shoes_formal_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_Shoes_formal_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Shoes" && itemList[i].category2 == "Formal Shoes")
                {
                    men_Shoes_formallListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();

                    men_Shoes_formallListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_Shoes_formallListview.Items.Add(itemListView);
                    men_Shoes_formal_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion

        #region men_shoes_sneakers
        private void men_Shoes_sneakerslPicBox_Click(object sender, EventArgs e)
        {
            men_Shoes_sneakerslPanel.BringToFront();
            men_Shoes_sneakersl_searchtxt.Clear();
            men_Shoes_sneakersl_refreshbtn.Visible = false;
            men_shoes_Sneakers_AddItem();
        }

        private void men_Shoes_sneakersllbl_Click(object sender, EventArgs e)
        {
            men_Shoes_sneakerslPanel.BringToFront();
            men_Shoes_sneakersl_searchtxt.Clear();
            men_Shoes_sneakersl_refreshbtn.Visible = false;
            men_shoes_Sneakers_AddItem();
        }

        private void men_Shoes_sneakersl_backbtn_Click(object sender, EventArgs e)
        {
            men_ShoesPanel.BringToFront();
        }

        private void men_Shoes_sneakersl_refreshbtn_Click(object sender, EventArgs e)
        {
            men_Shoes_sneakersl_refreshbtn.Visible = false;
            men_Shoes_sneakersl_searchtxt.Clear();
            men_shoes_Sneakers_AddItem();
        }

        private void men_Shoes_sneakersl_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_Shoes_sneakersl_searchtxt.Text == "")
                men_Shoes_sneakersl_searchtxtclearbtn.Visible = false;
            else
                men_Shoes_sneakersl_searchtxtclearbtn.Visible = true;
        }

        private void men_Shoes_sneakersl_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_Shoes_sneakersl_searchtxt.Clear();
            men_Shoes_sneakersl_searchtxtclearbtn.Visible = false;
        }

        private void men_Shoes_sneakersl_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_Shoes_sneakersl_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Shoes" && itemList[i].category2 == "Sneakers")
                {
                    men_Shoes_sneakerslListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_Shoes_sneakerslListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_Shoes_sneakerslListview.Items.Add(itemListView);
                    men_Shoes_sneakersl_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion

        #region men_shoes_boots
        private void men_Shoes_bootslPicBox_Click(object sender, EventArgs e)
        {
            men_Shoes_bootslPanel.BringToFront();
            men_Shoes_boots_searchtxt.Clear();
            men_Shoes_boots_refreshbtn.Visible = false;
            men_shoes_Boots_AddItem();
        }

        private void men_Shoes_bootsllbl_Click(object sender, EventArgs e)
        {
            men_Shoes_bootslPanel.BringToFront();
            men_Shoes_boots_searchtxt.Clear();
            men_Shoes_boots_refreshbtn.Visible = false;
            men_shoes_Boots_AddItem();
        }

        private void men_Shoes_boots_backbtn_Click(object sender, EventArgs e)
        {
            men_ShoesPanel.BringToFront();
        }

        private void men_Shoes_boots_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_Shoes_boots_searchtxt.Text == "")
                men_Shoes_boots_searchtxtclearbtn.Visible = false;
            else
                men_Shoes_boots_searchtxtclearbtn.Visible = true;
        }

        private void men_Shoes_boots_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_Shoes_boots_searchtxt.Clear();
            men_Shoes_boots_searchtxtclearbtn.Visible = false;
        }

        private void men_Shoes_boots_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_Shoes_boots_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Shoes" && itemList[i].category2 == "Boots")
                {
                    men_Shoes_bootsListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_Shoes_bootsListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_Shoes_bootsListview.Items.Add(itemListView);
                    men_Shoes_boots_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void men_Shoes_boots_refreshbtn_Click(object sender, EventArgs e)
        {
            men_Shoes_boots_refreshbtn.Visible = false;
            men_Shoes_boots_searchtxt.Clear();
            men_shoes_Boots_AddItem();
        }
        #endregion

        #region men_shoes_Casual
        private void men_Shoes_casualPicBox_Click(object sender, EventArgs e)
        {
            men_Shoes_casualPanel.BringToFront();
            men_Shoes_casual_searchtxt.Clear();
            men_Shoes_casual_refreshbtn.Visible = false;
            men_shoes_Casual_AddItem();
        }

        private void men_Shoes_casuallbl_Click(object sender, EventArgs e)
        {
            men_Shoes_casualPanel.BringToFront();
            men_Shoes_casual_searchtxt.Clear();
            men_Shoes_casual_refreshbtn.Visible = false;
            men_shoes_Casual_AddItem();
        }

        private void men_Shoes_casual_backbtn_Click(object sender, EventArgs e)
        {
            men_ShoesPanel.BringToFront();
        }

        private void men_Shoes_casual_refreshbtn_Click(object sender, EventArgs e)
        {
            men_Shoes_casual_refreshbtn.Visible = false;
            men_Shoes_casual_searchtxt.Clear();
            men_shoes_Casual_AddItem();
        }

        private void men_Shoes_casual_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_Shoes_casual_searchtxt.Text == "")
                men_Shoes_casual_searchtxtclearbtn.Visible = false;
            else
                men_Shoes_casual_searchtxtclearbtn.Visible = true;
        }

        private void men_Shoes_casual_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_Shoes_casual_searchtxt.Clear();
            men_Shoes_casual_searchtxtclearbtn.Visible = false;
        }

        private void men_Shoes_casual_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_Shoes_casual_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Shoes" && itemList[i].category2 == "Casual Shoes")
                {
                    men_Shoes_casualListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_Shoes_casualListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_Shoes_casualListview.Items.Add(itemListView);
                    men_Shoes_casual_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion


        #endregion

        #region men_winterWear
        private void men_WinterPicBox_Click(object sender, EventArgs e)
        {
            men_winterPanel.BringToFront();
        }

        private void men_Winterlbl_Click(object sender, EventArgs e)
        {
            men_winterPanel.BringToFront();
        }

        private void men_winterBackbtn_Click(object sender, EventArgs e)
        {
            menFashionPanel.BringToFront();
        }
        #region men_winter_AddItem
        void men_winter_Coats_AddItem()
        {
            int record = 0;
            men_winter_coatsListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Winter Wear" && itemList[i].category2 == "Jackets and Coats")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_winter_coatsListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_winter_coatsListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_winter_coats_recordlbl.Text = "Total record = " + record;
        }

        void men_winter_Hoodies_AddItem()
        {
            int record = 0;
            men_winter_hooodiesListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Winter Wear" && itemList[i].category2 == "Hoodies")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_winter_hooodiesListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_winter_hooodiesListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_winter_hooodies_recordlbl.Text = "Total record = " + record;
        }

        void men_winter_Sweaters_AddItem()
        {
            int record = 0;
            men_winter_sweatersListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Men" && itemList[i].category1 == "Winter Wear" && itemList[i].category2 == "Sweaters")
                {
                    ListViewItem itemListView = new ListViewItem();
                    men_winter_sweatersListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_winter_sweatersListview.Items.Add(itemListView);
                    ++record;
                }
            }
            men_winter_sweaters_recordlbl.Text = "Total record = " + record;
        }
        #endregion

        #region men_winter_coats
        private void men_winter_coatsPicBox_Click(object sender, EventArgs e)
        {
            men_winter_coatsPanel.BringToFront();
            men_winter_coats_searchtxt.Clear();
            men_winter_coats_refreshbtn.Visible = false;
            men_winter_Coats_AddItem();
        }

        private void men_winter_coatslbl_Click(object sender, EventArgs e)
        {
            men_winter_coatsPanel.BringToFront();
            men_winter_coats_searchtxt.Clear();
            men_winter_coats_refreshbtn.Visible = false;
            men_winter_Coats_AddItem();
        }

        private void men_winter_coats_backbtn_Click(object sender, EventArgs e)
        {
            men_winterPanel.BringToFront();
        }

        private void men_winter_coats_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_winter_coats_searchtxt.Text == "")
                men_winter_coats_searchtxtclearbtn.Visible = false;
            else
                men_winter_coats_searchtxtclearbtn.Visible = true;
        }

        private void men_winter_coats_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_winter_coats_searchtxt.Clear();
            men_winter_coats_searchtxtclearbtn.Visible = false;
        }

        private void men_winter_coats_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_winter_coats_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Winter Wear" && itemList[i].category2 == "Jackets and Coats")
                {
                    men_winter_coatsListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_winter_coatsListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_winter_coatsListview.Items.Add(itemListView);
                    men_winter_coats_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void men_winter_coats_refreshbtn_Click(object sender, EventArgs e)
        {
            men_winter_coats_refreshbtn.Visible = false;
            men_winter_coats_searchtxt.Clear();
            men_winter_Coats_AddItem();
        }
        #endregion

        #region men_winter_sweaters
        private void men_winter_sweatersPicBox_Click(object sender, EventArgs e)
        {
            men_winter_sweatersPanel.BringToFront();
            men_winter_sweaters_searchtxt.Clear();
            men_winter_sweaters_refreshbtn.Visible = false;
            men_winter_Sweaters_AddItem();
        }

        private void men_winter_sweaterslbl_Click(object sender, EventArgs e)
        {
            men_winter_sweatersPanel.BringToFront();
            men_winter_sweaters_searchtxt.Clear();
            men_winter_sweaters_refreshbtn.Visible = false;
            men_winter_Sweaters_AddItem();
        }

        private void men_winter_sweaters_backbtn_Click(object sender, EventArgs e)
        {
            men_winterPanel.BringToFront();
        }

        private void men_winter_sweaters_refreshbtn_Click(object sender, EventArgs e)
        {
            men_winter_sweaters_refreshbtn.Visible = false;
            men_winter_sweaters_searchtxt.Clear();
            men_winter_Sweaters_AddItem();
        }

        private void men_winter_sweaters_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_winter_sweaters_searchtxt.Text == "")
                men_winter_sweaters_searchtxtclearbtn.Visible = false;
            else
                men_winter_sweaters_searchtxtclearbtn.Visible = true;
        }

        private void men_winter_sweaters_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_winter_sweaters_searchtxt.Clear();
            men_winter_sweaters_searchtxtclearbtn.Visible = false;
        }

        private void men_winter_sweaters_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_winter_sweaters_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Winter Wear" && itemList[i].category2 == "Sweaters")
                {
                    men_winter_sweatersListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_winter_sweatersListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_winter_sweatersListview.Items.Add(itemListView);
                    men_winter_sweaters_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion

        #region men_winter_hoodies
        private void men_winter_hooodiesPicBox_Click(object sender, EventArgs e)
        {
            men_winter_hooodiesPanel.BringToFront();
            men_winter_hooodies_searchtxt.Clear();
            men_winter_hooodies_refreshbtn.Visible = false;
            men_winter_Hoodies_AddItem();
        }

        private void men_winter_hooodieslbl_Click(object sender, EventArgs e)
        {
            men_winter_hooodiesPanel.BringToFront();
            men_winter_hooodies_searchtxt.Clear();
            men_winter_hooodies_refreshbtn.Visible = false;
            men_winter_Hoodies_AddItem();
        }
        private void men_winter_hooodies_backbtn_Click(object sender, EventArgs e)
        {
            men_winterPanel.BringToFront();
        }

        private void men_winter_hooodies_refreshbtn_Click(object sender, EventArgs e)
        {
            men_winter_hooodies_refreshbtn.Visible = false;
            men_winter_hooodies_searchtxt.Clear();
            men_winter_Hoodies_AddItem();
        }

        private void men_winter_hooodies_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            men_winter_hooodies_searchtxt.Clear();
            men_winter_hooodies_searchtxtclearbtn.Visible = false;
        }

        private void men_winter_hooodies_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (men_winter_hooodies_searchtxt.Text == "")
                men_winter_hooodies_searchtxtclearbtn.Visible = false;
            else
                men_winter_hooodies_searchtxtclearbtn.Visible = true;
        }

        private void men_winter_hooodies_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (men_winter_hooodies_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Men" && itemList[i].category1 == "Winter Wear" && itemList[i].category2 == "Hoodies")
                {
                    men_winter_hooodiesListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    men_winter_hooodiesListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    men_winter_hooodiesListview.Items.Add(itemListView);
                    men_winter_hooodies_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion

       
        #endregion
        #endregion


        #region kidsFashion
         private void kidsfashionBackbtn_Click(object sender, EventArgs e)
        {
            homePanel.BringToFront();
        }

         private void kidsfashionPicBox_Click(object sender, EventArgs e)
         {
             kidsfashionPanel.BringToFront();
         }

         private void kidsfashionlbl_Click(object sender, EventArgs e)
         {
             kidsfashionPanel.BringToFront();
         }

#region kids_AddItem
        #region kids_Baby_AddItem
        void kids_Baby_clothes_AddItem()
        {
            int record = 0;
            kids_babys_clothesListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Kids" && itemList[i].category1 == "Baby" && itemList[i].category2 == "Clothes")
                {
                    ListViewItem itemListView = new ListViewItem();
                    kids_babys_clothesListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    kids_babys_clothesListview.Items.Add(itemListView);
                    ++record;
                }
            }
            kids_babys_clothes_recordlbl.Text = "Total record = " + record;
        }

        void kids_Baby_shoes_AddItem()
        {
            int record = 0;
            kids_babys_shoesListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Kids" && itemList[i].category1 == "Baby" && itemList[i].category2 == "Shoes")
                {
                    ListViewItem itemListView = new ListViewItem();
                    kids_babys_shoesListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    kids_babys_shoesListview.Items.Add(itemListView);
                    ++record;
                }
            }
            kids_babys_shoes_recordlbl.Text = "Total record = " + record;
        }

        void kids_Baby_Accessories_AddItem()
        {
            int record = 0;
            kids_babys_accessoriessListView.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Kids" && itemList[i].category1 == "Baby" && itemList[i].category2 == "Accessories")
                {
                    ListViewItem itemListView = new ListViewItem();
                    kids_babys_accessoriessListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    kids_babys_accessoriessListView.Items.Add(itemListView);
                    ++record;
                }
            }
            kids_babys_accessoriess_recordlbl.Text = "Total record = " + record;
        }
        #endregion

        #region kids_Boy_AddItem
        void kids_Boy_Shoes__AddItem()
        {
            int record = 0;
            kids_boysfashion_shoesListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Kids" && itemList[i].category1 == "Boy" && itemList[i].category2 == "Shoes")
                {
                    ListViewItem itemListView = new ListViewItem();
                    kids_boysfashion_shoesListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    kids_boysfashion_shoesListview.Items.Add(itemListView);
                    ++record;
                }
            }
            kids_boysfashion_shoes_recordlbl.Text = "Total record = " + record;
        }

        void kids_Boy_Accessories__AddItem()
        {
            int record = 0;
            kids_boysfashion_accessoriesListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Kids" && itemList[i].category1 == "Boy" && itemList[i].category2 == "Accessories")
                {
                    ListViewItem itemListView = new ListViewItem();
                    kids_boysfashion_accessoriesListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    kids_boysfashion_accessoriesListview.Items.Add(itemListView);
                    ++record;
                }
            }
            kids_boysfashion_accessories_recordlbl.Text = "Total record = " + record;
        }

        void kids_Boy_Clothes_Tshirts_AddItem()
        {
            int record = 0;

            kids_boys_clothes_TshirtsListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Kids" && itemList[i].category1 == "Boy" && itemList[i].category2 == "Clothes" && itemList[i].category3 == "Shirts")
                {
                    ListViewItem itemListView = new ListViewItem();
                    kids_boys_clothes_TshirtsListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    kids_boys_clothes_TshirtsListview.Items.Add(itemListView);
                    ++record;
                }
            }
            kids_boys_clothes_recordlbl.Text = "Total record = " + record;
        }

        void kids_Boy_Clothes_Jeans_AddItem()
        {
            int record = 0;

            kids_boys_clothes_jeansListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Kids" && itemList[i].category1 == "Boy" && itemList[i].category2 == "Clothes" && itemList[i].category3 == "Jeans")
                {
                    ListViewItem itemListView = new ListViewItem();
                    kids_boys_clothes_jeansListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    kids_boys_clothes_jeansListview.Items.Add(itemListView);
                    ++record;
                }
            }
            kids_boys_clothes_jeans_recordlbl.Text = "Total record = " + record;
        }

        void kids_Boy_Clothes_Winter_AddItem()
        {
            int record = 0;

            kids_boys_clothes_wintersListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Kids" && itemList[i].category1 == "Boy" && itemList[i].category2 == "Clothes" && itemList[i].category3 == "Winter Wear")
                {
                    ListViewItem itemListView = new ListViewItem();
                    kids_boys_clothes_wintersListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    kids_boys_clothes_wintersListview.Items.Add(itemListView);
                    ++record;
                }
            }
            kids_boys_clothes_winters_recordlbl.Text = "Total record = " + record;
        }
        #endregion

        #region kids_Girl_AddItem
        void kids_Girl_Clothes_kurtas_AddItem()
        {
            int record = 0;

            kids_girls_clothes_kurtas_Listview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Kids" && itemList[i].category1 == "Girl" && itemList[i].category2 == "Clothes" && itemList[i].category3 == "Kurtas and Shalwar Kamiz")
                {
                    ListViewItem itemListView = new ListViewItem();
                    kids_girls_clothes_kurtas_Listview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    kids_girls_clothes_kurtas_Listview.Items.Add(itemListView);
                    ++record;
                }
            }
            kids_girls_clothes_kurtas_recodlbl.Text = "Total record = " + record;
        }

        void kids_Girl_Clothes_pants_AddItem()
        {
            int record = 0;

            kids_girls_clothes_pantsListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Kids" && itemList[i].category1 == "Girl" && itemList[i].category2 == "Clothes" && itemList[i].category3 == "Pants")
                {
                    ListViewItem itemListView = new ListViewItem();
                    kids_girls_clothes_pantsListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    kids_girls_clothes_pantsListview.Items.Add(itemListView);
                    ++record;
                }
            }
            kids_girls_clothes_pants_recordlbl.Text = "Total record = " + record;
        }

        void kids_Girl_Clothes_frock_AddItem()
        {
            int record = 0;

            kids_girls_clothes_frocksListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Kids" && itemList[i].category1 == "Girl" && itemList[i].category2 == "Clothes" && itemList[i].category3 == "Frocks")
                {
                    ListViewItem itemListView = new ListViewItem();
                    kids_girls_clothes_frocksListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    kids_girls_clothes_frocksListview.Items.Add(itemListView);
                    ++record;
                }
            }
            kids_girls_clothes_frocks_recordlbl.Text = "Total record = " + record;
        }

        void kids_Girl_Clothes_winter_AddItem()
        {
            int record = 0;

            kids_girls_clothes_winterListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Kids" && itemList[i].category1 == "Girl" && itemList[i].category2 == "Clothes" && itemList[i].category3 == "Winter Wear")
                {
                    ListViewItem itemListView = new ListViewItem();
                    kids_girls_clothes_winterListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    kids_girls_clothes_winterListview.Items.Add(itemListView);
                    ++record;
                }
            }

            kids_girls_clothes_winter_recordlbl.Text = "Total record = " + record;
        }

        void kids_Girl_Accessories__AddItem()
        {
            int record = 0;
            kids_girlsfashion_accessoriesListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Kids" && itemList[i].category1 == "Girl" && itemList[i].category2 == "Accessories")
                {
                    ListViewItem itemListView = new ListViewItem();
                    kids_girlsfashion_accessoriesListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    kids_girlsfashion_accessoriesListview.Items.Add(itemListView);
                    ++record;
                }
            }
            kids_girlsfashion_accessories_recordlbl.Text = "Total record = " + record;
        }

        void kids_Girl_Shoes__AddItem()
        {
            int record = 0;
            kids_girlsfashion_shoesListview.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].category == "Kids" && itemList[i].category1 == "Girl" && itemList[i].category2 == "Shoes")
                {
                    ListViewItem itemListView = new ListViewItem();
                    kids_girlsfashion_shoesListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    kids_girlsfashion_shoesListview.Items.Add(itemListView);
                    ++record;
                }
            }
            kids_girlsfashion_shoes_recordlbl.Text = "Total record = " + record;
        }
        #endregion
        #endregion

#region kids_boy
        private void pictureBox56_Click(object sender, EventArgs e)
        {
            kids_boysfashionPanel.BringToFront();
        }

        private void label56_Click(object sender, EventArgs e)
        {
            kids_boysfashionPanel.BringToFront();
        }

#region kids_boy_clothes

#endregion

#region kids_boy_shoes
#endregion

#region kids_boy_accessories
#endregion

#endregion

#region kids_girl
        private void pictureBox57_Click(object sender, EventArgs e)
        {
            kids_girlsfashionPanel.BringToFront();
        }

        private void label57_Click(object sender, EventArgs e)
        {
            kids_girlsfashionPanel.BringToFront();
        }
#endregion

#region kids_baby
        private void BabysfashionPicBox_Click(object sender, EventArgs e)
        {
            kids_babysfashionPanel.BringToFront();
        }

        private void Babysfashionlbl_Click(object sender, EventArgs e)
        {
            kids_babysfashionPanel.BringToFront();
        }
#endregion

        

        

#endregion

        #region kids_babys_clothes
        private void kids_babys_clothes_backbtn_Click(object sender, EventArgs e)
        {
            kids_babysfashionPanel.BringToFront();
        }

        private void kids_babys_clothes_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (kids_babys_clothes_searchtxt.Text == "")
                kids_babys_clothes_searchtxt_clearbtn.Visible = false;
            else
                kids_babys_clothes_searchtxt_clearbtn.Visible = true;
        }

        private void kids_babys_clothes_searchtxt_clearbtn_Click(object sender, EventArgs e)
        {
            kids_babys_clothes_searchtxt.Clear();
            kids_babys_clothes_searchtxt_clearbtn.Visible = false;
        }

        private void kids_babys_clothes_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (kids_babys_clothes_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Kids" && itemList[i].category1 == "Baby" && itemList[i].category2 == "Clothes")
                {
                    kids_babys_clothesListview.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    kids_babys_clothesListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    kids_babys_clothesListview.Items.Add(itemListView);
                    kids_babys_clothes_Refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void kids_babys_clothes_Refreshbtn_Click(object sender, EventArgs e)
        {
            kids_babys_clothes_Refreshbtn.Visible = false;
            kids_babys_clothes_searchtxt.Clear();
            kids_Baby_clothes_AddItem();
        }
        #endregion

        #region kids_babys_shoes
        private void kids_babys_shoes_backbtn_Click(object sender, EventArgs e)
        {
            kids_babysfashionPanel.BringToFront();
        }

        private void kids_babys_shoes_refreshbtn_Click(object sender, EventArgs e)
        {
            kids_babys_shoes_refreshbtn.Visible = false;
            kids_babys_shoes_searchtxt.Clear();
            kids_Baby_shoes_AddItem();
        }

        private void kids_babys_shoes_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (kids_babys_shoes_searchtxt.Text == "")
                kids_babys_shoes_searchtxt_clearbtn.Visible = false;
            else
                kids_babys_shoes_searchtxt_clearbtn.Visible = true;
        }

        private void kids_babys_shoes_searchtxt_clearbtn_Click(object sender, EventArgs e)
        {
            kids_babys_shoes_searchtxt.Clear();
            kids_babys_shoes_searchtxt_clearbtn.Visible = false;
        }

        private void kids_babys_shoes_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (kids_babys_shoes_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Kids" && itemList[i].category1 == "Baby" && itemList[i].category2 == "Shoes")
                {
                    kids_babys_shoesListview.Items.Clear();
                    
                    ListViewItem itemListView = new ListViewItem();
                    kids_babys_shoesListview.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    kids_babys_shoesListview.Items.Add(itemListView);
                    kids_babys_shoes_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion

        #region kids_babys_accessories
        private void kids_babys_accessoriess_backbtn_Click(object sender, EventArgs e)
        {
            kids_babysfashionPanel.BringToFront();
        }

        private void kids_babys_accessoriess_refreshbtn_Click(object sender, EventArgs e)
        {
            kids_babys_accessoriess_refreshbtn.Visible = false;
            kids_babys_clothes_searchtxt.Clear();
            kids_Baby_clothes_AddItem();
        }

        private void kids_babys_accessoriess_searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (kids_babys_accessoriess_searchtxt.Text == "")
                kids_babys_accessoriess_searchtxtclearbtn.Visible = false;
            else
                kids_babys_accessoriess_searchtxtclearbtn.Visible = true;
        }

        private void kids_babys_accessoriess_searchtxtclearbtn_Click(object sender, EventArgs e)
        {
            kids_babys_accessoriess_searchtxt.Clear();
            kids_babys_accessoriess_searchtxtclearbtn.Visible = false;
        }

        private void kids_babys_accessoriess_searchbtn_Click(object sender, EventArgs e)
        {
            int secret = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (kids_babys_accessoriess_searchtxt.Text == itemList[i].barcode && itemList[i].category == "Kids" && itemList[i].category1 == "Baby" && itemList[i].category2 == "Accessories")
                {
                    kids_babys_accessoriessListView.Items.Clear();

                    ListViewItem itemListView = new ListViewItem();
                    kids_babys_accessoriessListView.SmallImageList = images;
                    itemListView.ImageIndex = i;
                    itemListView.SubItems.Add(itemList[i].name);
                    itemListView.SubItems.Add(itemList[i].barcode);
                    itemListView.SubItems.Add("RS" + itemList[i].price.ToString());
                    itemListView.SubItems.Add(itemList[i].quantity.ToString());
                    itemListView.SubItems.Add(itemList[i].color);
                    itemListView.SubItems.Add(itemList[i].material);

                    kids_babys_accessoriessListView.Items.Add(itemListView);
                    kids_babys_accessoriess_refreshbtn.Visible = true;
                    break;
                }
                else
                {
                    if (i == itemList.Count - 1)
                        secret = 58;
                }
            }
            if (secret == 58)
            {
                MessageBox.Show("Item not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion











    }
}
