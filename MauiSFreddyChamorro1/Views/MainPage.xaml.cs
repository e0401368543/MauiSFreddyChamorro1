namespace MauiSFreddyChamorro1.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    private void btnCalcularIESS_Clicked(object sender, EventArgs e)
    {

        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        double iess = 0.00;
        decimal salario = Convert.ToDecimal(txtSalario.Text);

        if (salario == 0)
        {
            DisplayAlert("Alerta", "El Salario debe ser mayo a CERO " + txtSalario.Text, "Salir");
        }

        else
        {
            iess = Math.Round(Convert.ToDouble(txtSalario.Text) * 9.45/100, 2);
        }

        char? inputChar = string.IsNullOrEmpty(nombre) ? (char?)null : nombre[0];

        if (inputChar != null) {
        DisplayAlert("Calculando Aporte del Asegurado", "Bienvenido " + nombre + " " + apellido + "\n" 
                    + "Tienes : " + txtEdad.Text + " años"
                     + "\nTu aporte mensual es: " + iess, "Close");

        }
        else
        {
            DisplayAlert("Alerta", "Ingrese un nombre válido", "Salir");

        }

      


    }

    private char ConvertToCharOrDefault(char? input, char defaultValue = ' ')
    {
        return input ?? defaultValue;
    }

}