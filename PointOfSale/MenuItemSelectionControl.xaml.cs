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
using BleakwindBuffet.Data.Drinks;
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

        
        void DoubleDraugrClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            orderControl.SwapScreen(new DoubleDraugr());
        }

        void BriarheartBurgerClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            orderControl.SwapScreen(new BriarheartBurger());
        }

        void GardenOrcOmeletteClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            orderControl.SwapScreen(new GardenOrcOmelette());
        }

        void PhillyPoacherClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            orderControl.SwapScreen(new PhillyPoacher());
        }

        void ThalmorTripleClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            orderControl.SwapScreen(new ThalmorTriple());
        }

        void ThugsTBoneClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            orderControl.SwapScreen(new ThugsTBone());
        }

        void SmokehouseSkeletonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            orderControl.SwapScreen(new SmokehouseSkeleton());
        }


        void SailorSodaClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            orderControl.SwapScreen(new SailorSoda());
        }

        void AretinoAppleJuiceClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            orderControl.SwapScreen(new ArentinoAppleJuice());
        }

        void MarkarthMilkClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            orderControl.SwapScreen(new MarkarthMilk());
        }

        void CandlehearthCoffeeClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            orderControl.SwapScreen(new CandlehearthCoffee());
        }

        void WarriorWaterClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            orderControl.SwapScreen(new WarriorWater());
        }


        void FriedMiraakClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            orderControl.SwapScreen(new FriedMiraak());
        }

        void MadOtarGritsClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            orderControl.SwapScreen(new MadOtarGrits());
        }

        void DragonbornFriesClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            orderControl.SwapScreen(new DragonbornWaffleFries());
        }

        void VokunSaladClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            orderControl.SwapScreen(new VokunSalad());
        }
    }
}
