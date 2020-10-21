/*
 * Author: Jacob Beck
 * Class name: MenuItemSelectionControl.xaml.cs
 * Purpose: Class used to represent the customers menu order.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using PointOfSale.ExtensionMethod;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        
        public MenuItemSelectionControl() 
        {
            InitializeComponent();
        }



        void AddCombo_Click(object sender, RoutedEventArgs e)
        {
            Entree entree = new BriarheartBurger();
            Side side = new DragonbornWaffleFries();
            Drink drink = new WarriorWater();

            Combo combo = new Combo(entree, side, drink);

            if(DataContext is Order item)
            {
                item.Add(combo);
            }

            var orderControl = this.FindAncestor<RefactorControl>(); // Messed up

            orderControl.SwapScreen(new ComboSelection());
        }

        void DoubleDraugrClick(object sender, RoutedEventArgs e)
        {
            DoubleDraugr dd = new DoubleDraugr();

            var order = DataContext as Order;
            order.Add(dd);

            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            var x = new DoubleDraugrC();
            x.DataContext = dd;
            orderControl.SwapScreen(x);
        }

        void BriarheartBurgerClick(object sender, RoutedEventArgs e)
        {
            BriarheartBurger bb = new BriarheartBurger();

            var order = DataContext as Order;
            order.Add(bb);

            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            var x = new BriarheartBurgerC();
            x.DataContext = bb;
            orderControl.SwapScreen(x);
        }

        void GardenOrcOmeletteClick(object sender, RoutedEventArgs e)
        {
           GardenOrcOmelette goc = new GardenOrcOmelette();

            var order = DataContext as Order;
            order.Add(goc);

            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            var x = new GardenOrcOmeletteC();
            x.DataContext = goc;
            orderControl.SwapScreen(x);
        }

        void PhillyPoacherClick(object sender, RoutedEventArgs e)
        {
           PhillyPoacher pp = new PhillyPoacher();

            var order = DataContext as Order;
            order.Add(pp);

            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            var x = new PhillyPoacherC();
            x.DataContext = pp;
            orderControl.SwapScreen(x);
        }

        void ThalmorTripleClick(object sender, RoutedEventArgs e)
        {
           ThalmorTriple tt = new ThalmorTriple();

            var order = DataContext as Order;
            order.Add(tt);

            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            var x = new ThalmorTripleC();
            x.DataContext = tt;
            orderControl.SwapScreen(x);
        }

        void ThugsTBoneClick(object sender, RoutedEventArgs e)
        {
            ThugsTBone ttb = new ThugsTBone();

            var order = DataContext as Order;
            order.Add(ttb);

            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            var x = new ThugsTBoneC();
            x.DataContext = ttb;
            orderControl.SwapScreen(x);
        }

        void SmokehouseSkeletonClick(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();

            var order = DataContext as Order;
            order.Add(ss);

            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            var x = new SmokehouseSkeletonC();
            x.DataContext = ss;
            orderControl.SwapScreen(x);
        }


        void SailorSodaClick(object sender, RoutedEventArgs e)
        {
            SailorSoda ss = new SailorSoda();

            var order = DataContext as Order;
            order.Add(ss);

            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            var x = new SailorSodaC();
            x.DataContext = ss;
            orderControl.SwapScreen(x);
        }

        void AretinoAppleJuiceClick(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice aa = new AretinoAppleJuice();

            var order = DataContext as Order;
            order.Add(aa);

            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            var x = new AretinoAppleJuiceC();
            x.DataContext = aa;
            orderControl.SwapScreen(x);
        }

        void MarkarthMilkClick(object sender, RoutedEventArgs e)
        {
            MarkarthMilk mm = new MarkarthMilk();

            var order = DataContext as Order;
            order.Add(mm);

            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            var x = new MarkarthMilkC();
            x.DataContext = mm;
            orderControl.SwapScreen(x);
        }

        void CandlehearthCoffeeClick(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();

            var order = DataContext as Order;
            order.Add(cc);

            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            var x = new CandlehearthCoffeeC();
            x.DataContext = cc;
            orderControl.SwapScreen(x);
        }

        void WarriorWaterClick(object sender, RoutedEventArgs e)
        {
            WarriorWater ww = new WarriorWater();

            var order = DataContext as Order;
            order.Add(ww);

            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            var x = new WarriorWaterC();
            x.DataContext = ww;
            orderControl.SwapScreen(x);
        }


        void FriedMiraakClick(object sender, RoutedEventArgs e)
        {
           FriedMiraak fm = new FriedMiraak();

            var order = DataContext as Order;
            order.Add(fm);

            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            var x = new FriedMiraakC();
            x.DataContext = fm;
            orderControl.SwapScreen(x);
        }

        void MadOtarGritsClick(object sender, RoutedEventArgs e)
        {
            MadOtarGrits mog = new MadOtarGrits();

            var order = DataContext as Order;
            order.Add(mog);

            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            var x = new MadOtarGritsC();
            x.DataContext = mog;
            orderControl.SwapScreen(x);
        }

        void DragonbornFriesClick(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();

            var order = DataContext as Order;
            order.Add(wf);

            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            var x = new DragonbornWaffleFriesC();
            x.DataContext = wf;
            orderControl.SwapScreen(x);
        }

        void VokunSaladClick(object sender, RoutedEventArgs e)
        {
            VokunSalad vs = new VokunSalad();

            var order = DataContext as Order;
            order.Add(vs);

            var orderControl = this.FindAncestor<MenuSelectionScreen>();
            
            var x = new VokunSaladC();
            x.DataContext = vs;
            orderControl.SwapScreen(x);
        }
    }
}
