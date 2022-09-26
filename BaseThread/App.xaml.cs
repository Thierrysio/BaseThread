using BaseThread.Vues;

namespace BaseThread;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ThreadVue();
	}
}
