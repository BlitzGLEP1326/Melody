using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Gtk;

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
		Gtk.Application.Quit ();
		//throw new NotImplementedException ();
	}
}
