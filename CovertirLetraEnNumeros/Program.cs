String[] unidades =
{
    "",
    "Uno",
    "Dos",
    "Tres",
    "Cuatro",
    "Cinco",
    "Seis",
    "Siete",
    "Ocho",
    "Nueve",
};

String[] decenas =
{
    "",
    "Diez",
    "veinte",
    "Treinta",
    "Cuarenta",
    "Cincuenta",
    "Sesenta",
    "Setenta",
    "Ochenta",
    "Noventa"
};

String[] Centenas =
{
    "",
    "Ciento",
    "Doscientos",
    "Trescientos",
    "Cuatrocientos",
    "Quinientos",
    "Seiscientos",
    "Setecientos",
    "Ochocientos",
    "Nuevecientos",
};

String[] especiales =
{
    
    "",
    "Once",
    "Doce",
    "Trece",
    "Catorce",
    "Quince",
    "Dieciséis",
    "Diecisiete",
    "Diecicho",
    "Diecinueve",
};

int numero;
while (true)
{
    Console.Write("Ingrese un numero entre 0 y 9999: ");
    

    if (int.TryParse(Console.ReadLine(), out numero))
    {
        if(numero >= 0 && numero <= 9999)
        {
            String NumeroEnLetra = ConvertirNumeroEnletra(numero);
            Console.WriteLine($"El número {numero} en letras es: {NumeroEnLetra}");
        }

        else
            Console.WriteLine("El número está fuera del rango");

    }
    else
        Console.WriteLine("Entrada no válida, por favor ingrese un número válido");
    

}

string ConvertirNumeroEnletra(int numero)
{
    if (numero == 0)
        return "cero";
    if (numero == 100)
        return "cien";
    if (numero == 1100)
        return "Mil cien";

    String numeroEnLetras = "";

    //procesar las unidades en millar
    int unidadesDeMillar = numero / 1000;

    if (unidadesDeMillar > 0)
    {
        if (unidadesDeMillar == 1)
            numeroEnLetras = "Mil ";

        else
        numeroEnLetras += unidades[unidadesDeMillar] + "Mil ";
        numero %= 1000;
    }

    //procesar las centenas
    int unidadesDeCentecimas = numero / 100;

    if (unidadesDeCentecimas > 0)
    {

        if (unidadesDeCentecimas == 1)
        {
            numeroEnLetras += Centenas[unidadesDeCentecimas] + " ";
            numero %= 100;
        }
    }

    //procesar las decenas y unidades
   
    if (numero >= 10 && numero <= 19)
    {
        numeroEnLetras += especiales[numero - 10];
    }

    else
    {
        int decena = numero / 10;
        if (decena > 0)
        {
            numeroEnLetras += decenas[decena];
            if(numero % 10 > 0)
                numeroEnLetras += " y " + unidades[numero % 10];
        }
        else if (numero % 10 > 0)
            numeroEnLetras +=unidades[numero%10];   

    }

    return numeroEnLetras;
}