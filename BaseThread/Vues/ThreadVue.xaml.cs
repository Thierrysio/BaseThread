using BaseThread.VueModeles;

namespace BaseThread.Vues;

public partial class ThreadVue : ContentPage
{
	ThreadVueModele vueModele;
	public ThreadVue()
	{
		InitializeComponent();
		BindingContext = vueModele = new ThreadVueModele();

		vueModele.LanceThread();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		leLabel.Text = "le numero actuel est de " + mesNumeros.Text;
	}
}