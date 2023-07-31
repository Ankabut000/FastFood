﻿using FastFood.Pages.AddProducts;
using FastFood.Pages.AlItems;
using FastFood.Pages.ColdDrinks;
using FastFood.Pages.Disserts;
using FastFood.Pages.Foods;
using FastFood.Pages.HotDrinks;
using System.Windows;
using System.Windows.Input;

namespace FastFood;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        // Is_Admin
        AllItemsPage allItemsPage = new AllItemsPage();
        PageNavigator.Content = allItemsPage;

        //rbCreateProducts.Visibility = Visibility.Collapsed;
        //rbCreateProducts.Visibility = Visibility.Visible;
    }

    private void btnMinimize_Click(object sender, RoutedEventArgs e)
    {
        this.WindowState = WindowState.Minimized;
    }

    private void btnMaximize_Click(object sender, RoutedEventArgs e)
    {
        if (this.WindowState == WindowState.Maximized)
            this.WindowState = WindowState.Normal;
        else this.WindowState = WindowState.Maximized;
    }

    private void btnClose_Click(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }

    private void brDragable_MouseDown(object sender, MouseButtonEventArgs e)
    {
        this.DragMove();
    }

    private void rbColdDrinks_Click(object sender, RoutedEventArgs e)
    {
        drResult.Visibility = Visibility.Visible;
        ColdDrinksPage coldDrinksPage = new ColdDrinksPage();
        PageNavigator.Content = coldDrinksPage;
    }

    private void rbHotDrinks_Click(object sender, RoutedEventArgs e)
    {
        drResult.Visibility = Visibility.Visible;
        HotDrinksPage hotDrinksPage = new HotDrinksPage();
        PageNavigator.Content = hotDrinksPage;
    }

    private void rb_Food_Click(object sender, RoutedEventArgs e)
    {
        drResult.Visibility = Visibility.Visible;
        FoodPage foodPage = new FoodPage();
        PageNavigator.Content = foodPage;
    }

    private void rb_AllItems_Click(object sender, RoutedEventArgs e)
    {
        drResult.Visibility = Visibility.Visible;
        AllItemsPage allItemsPage = new AllItemsPage();
        PageNavigator.Content = allItemsPage;
    }

    private void rbDisserts_Click(object sender, RoutedEventArgs e)
    {
        drResult.Visibility = Visibility.Visible;
        DissertsPage dissertsPage = new DissertsPage();
    }

    private void rbCreateProduct_Click(object sender, RoutedEventArgs e)
    {
        drResult.Visibility = Visibility.Collapsed;
        CreateProductPage createProductPage = new CreateProductPage();
        PageNavigator.Content = createProductPage;
    }
}
