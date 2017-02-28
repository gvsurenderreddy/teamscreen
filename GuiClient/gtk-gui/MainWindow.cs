
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox2;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Entry txtHostSystemId;

	private global::Gtk.Entry txtHostPassword;

	private global::Gtk.Button btnLogin;

	private global::Gtk.Image drawingArea;

	private global::Gtk.Label lblStatus;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.txtHostSystemId = new global::Gtk.Entry();
		this.txtHostSystemId.CanFocus = true;
		this.txtHostSystemId.Name = "txtHostSystemId";
		this.txtHostSystemId.IsEditable = true;
		this.txtHostSystemId.InvisibleChar = '•';
		this.hbox2.Add(this.txtHostSystemId);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.txtHostSystemId]));
		w1.Position = 0;
		// Container child hbox2.Gtk.Box+BoxChild
		this.txtHostPassword = new global::Gtk.Entry();
		this.txtHostPassword.CanFocus = true;
		this.txtHostPassword.Name = "txtHostPassword";
		this.txtHostPassword.IsEditable = true;
		this.txtHostPassword.InvisibleChar = '•';
		this.hbox2.Add(this.txtHostPassword);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.txtHostPassword]));
		w2.Position = 1;
		// Container child hbox2.Gtk.Box+BoxChild
		this.btnLogin = new global::Gtk.Button();
		this.btnLogin.CanFocus = true;
		this.btnLogin.Name = "btnLogin";
		this.btnLogin.UseUnderline = true;
		this.btnLogin.Label = global::Mono.Unix.Catalog.GetString("Login");
		this.hbox2.Add(this.btnLogin);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.btnLogin]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		this.vbox2.Add(this.hbox2);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.drawingArea = new global::Gtk.Image();
		this.drawingArea.Name = "drawingArea";
		this.vbox2.Add(this.drawingArea);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.drawingArea]));
		w5.Position = 1;
		// Container child vbox2.Gtk.Box+BoxChild
		this.lblStatus = new global::Gtk.Label();
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.LabelProp = global::Mono.Unix.Catalog.GetString("Status");
		this.vbox2.Add(this.lblStatus);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.lblStatus]));
		w6.PackType = ((global::Gtk.PackType)(1));
		w6.Position = 2;
		w6.Expand = false;
		w6.Fill = false;
		this.Add(this.vbox2);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 404;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.btnLogin.Clicked += new global::System.EventHandler(this.OnBtnLoginClicked);
	}
}