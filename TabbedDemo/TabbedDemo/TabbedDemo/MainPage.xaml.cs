using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabbedDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ObservableCollection<Modelo.ModeloBoton> lstBotones = new ObservableCollection<Modelo.ModeloBoton>();

            lstBotones.Add(new Modelo.ModeloBoton { 
                ColorFondo = Color.Red,
                ColorTexto = Color.Black,
                Id = 1,
                TextoBoton = "Burgers"
            });

            lstBotones.Add(new Modelo.ModeloBoton
            {
                ColorFondo = Color.Red,
                ColorTexto = Color.Black,
                Id = 1,
                TextoBoton = "Burgers"
            });

            lstBotones.Add(new Modelo.ModeloBoton
            {
                ColorFondo = Color.Aqua,
                ColorTexto = Color.Black,
                Id = 1,
                TextoBoton = "Burgers"
            });

            lstBotones.Add(new Modelo.ModeloBoton
            {
                ColorFondo = Color.Aqua,
                ColorTexto = Color.Black,
                Id = 1,
                TextoBoton = "Burgers"
            });

            lstBotones.Add(new Modelo.ModeloBoton
            {
                ColorFondo = Color.Chartreuse,
                ColorTexto = Color.White,
                Id = 1,
                TextoBoton = "Burgers"
            });

            lstBotones.Add(new Modelo.ModeloBoton
            {
                ColorFondo = Color.Chartreuse,
                ColorTexto = Color.Black,
                Id = 1,
                TextoBoton = "Burgers"
            });

            lstBotones.Add(new Modelo.ModeloBoton
            {
                ColorFondo = Color.Chartreuse,
                ColorTexto = Color.Black,
                Id = 1,
                TextoBoton = "Burgers"
            });


            lstBotones.Add(new Modelo.ModeloBoton
            {
                ColorFondo = Color.DarkOrange,
                ColorTexto = Color.Black,
                Id = 1,
                TextoBoton = "Burgers"
            });

            lstBotones.Add(new Modelo.ModeloBoton
            {
                ColorFondo = Color.DimGray,
                ColorTexto = Color.White,
                Id = 1,
                TextoBoton = "Burgers"
            });

            cllBotones.ItemsSource = lstBotones;
        }
    }
}
