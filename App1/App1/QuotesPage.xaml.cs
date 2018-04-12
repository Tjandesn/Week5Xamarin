using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotesPage : ContentPage
	{
        int quoteCount = 0;
        string[] quotes = {"Leave something for someone but dont leave someone for something. - Enid Blyton",
               "Politicians and Diapers must be changed often, and for the same reason. - Mark Twain",
               "Always borrow money from a pessimist. He wont expect it back. - Oscar Wilde",
               "'Be Yourself' is about the worst advice you can give some people. - Thomas Lansing Masson",
               "Remember, today is the tomorrow you worried about yesterday. - Dale Carnegie"
            };

        public QuotesPage ()
		{
			InitializeComponent ();
            lblQuotes.Text = quotes[quoteCount];
        }

        private void btnNextQuote_Clicked(object sender, EventArgs e)
        {
            Random rand = new Random();
            quoteCount = rand.Next(0,5);
            string displayQuote = quotes[quoteCount];
            lblQuotes.Text = quotes[quoteCount];
        }
    }
}