using System;

public partial class BootcampService : ServiceBase
{
	Bootcamp campo;

	public BootcampService()
	{
		InitializeComponent();
	}

	protected override void OnStart(string[] args)
	{
		campo = new Bootcamp(args[0],args[1] );         
	}

	protected override void OnStop()
	{

	}

	public void set_X(int width)
	{
		this.campo.set_X(width);
	}

	public int get_X()
	{
		return this.campo.get_X();
	}

	public void set_Y(int height)
	{
		this.campo.set_Y(height);
	}

	public int get_Y()
	{
		return this.campo.get_Y();
	}

	public int[,] getCamp()
	{
		return this.campo.getCamp();
	}

	public string display(int x, int y)
	{
	   return this.campo.display(x,y);
	}

	public void changeBomb(int x, int y)
	{
		this.campo.changeBomb(x,y);
	}

	public void setBomb(int x, int y)
	{
		this.campo.setBomb(x,y);
	 }

	public void clear(int x, int y)
	{
		this.campo.clear(x,y);
	}
}


