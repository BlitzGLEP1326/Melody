using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Gtk;

namespace Melody
{
public partial class MainWindow: Gtk.Window
{
	//конструктор окна
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	//событие нажатия на кнопку Выход
	protected void ButtonExit_Clicked (object sender, EventArgs e)
	{
		//выходим из программы
		Gtk.Application.Quit ();
		//throw new NotImplementedException ();
	}

	//событие нажатия кнопки вызова окна параметров
	protected void ButtonFParams_Clicked (object sender, EventArgs e)
	{
		fParam fp = new fParam ();
			fp.Show ();
		//throw new NotImplementedException ();
	}
}
}
