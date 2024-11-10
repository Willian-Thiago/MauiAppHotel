using MauiAppHotel.Models;
using System.Collections.Generic;

namespace MauiAppHotel.Views;


public partial class Suites : ContentPage
{
	public Suites()
	{
		InitializeComponent();

		//Lista de dados para o CarouselView

		var suites = new List<SuiteItem>
		{
			new SuiteItem {ImageSource = "super_luxo.jpg",
                Description = "Super Luxo",
                LeftLabel1 = "Ar condicionado",
                LeftIcon1 = "ar.png",
                LeftLabel2 = "Janelas anti-ruído",
                LeftIcon2 = "janela.png",
                LeftLabel3 = "Cortinas Blackout",
                LeftIcon3 = "cortina.png",
                RightLabel1 = "Cama King size",
                RightIcon1 = "cama.png",
                RightLabel2 = "Smart Tv",
                RightIcon2 = "smarttv.png",
                RightLabel3 = "Hidromassagem",
                RightIcon3 = "banheira.png"
            },
			

			new SuiteItem {ImageSource = "luxo.jpg", 
				Description = "Luxo",
                LeftLabel1 = "Ar condicionado",
                LeftIcon1 = "ar.png",
                LeftLabel2 = "Janelas anti-rído",
                LeftIcon2 = "janela.png",
                LeftLabel3 = "Cortinas Blackout",
                LeftIcon3 = "cortina.png",
                RightLabel1 = "Cama King size",
                RightIcon1 = "cama.png",
                RightLabel2 = "Smart Tv",
                RightIcon2 = "smarttv.png",
                RightLabel3 = "Mini-Bar",
                RightIcon3 = "minibar.png"
            },

			new SuiteItem {ImageSource = "single.jpg", 
				Description = "Single",
                LeftLabel1 = "Ar condicionado",
                LeftIcon1 = "ar.png",
                LeftLabel2 = "Janelas anti-rído",
                LeftIcon2 = "janela.png",
                LeftLabel3 = "Cortinas Blackout",
                LeftIcon3 = "cortina.png",
                RightLabel1 = "Wi-fi",
                RightIcon1 = "wifi.png",
                RightLabel2 = "Smart Tv",
                RightIcon2 = "smarttv.png",
                RightLabel3 = "Mini-Bar",
                RightIcon3 = "minibar.png"
            },

			new SuiteItem {ImageSource = "crise.jpg",
                Description = "Crise",
                LeftLabel1 = "Ventilador",
                LeftIcon1 = "ventilador.png",
                LeftLabel2 = "Secador de cabelo",
                LeftIcon2 = "secador.png",

                RightLabel1 = "Wi-fi",
                RightIcon1 = "wifi.png",
                RightLabel2 = "TV LCD",
                RightIcon2 = "lcd.png"
            }
                
		};

		//Definindo o BidingContext da página da lista de suítes

		BindingContext = suites;

	}

    private void Button_Clicked(object sender, EventArgs e)

    {
        try
        {
            Navigation.PushAsync(new ContratacaoHospedagem());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }
}