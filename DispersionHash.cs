using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolBinario
{
    public class DispersionHash
    {
        static int M = 1024;
        static double R = 0.618034;
        static long transformaClave(String clave)
        {
            long d;
            d = 0;
            for (int j = 0; j < Math.min(clave.length(), 10); j++)
            {
                d = d * 27 + (int)clave.charAt(j);
            }
            /*
            Para un valor mayor que el máximo entero genera un
            numero negativo.
            */
            if (d < 0) d = -d;
            return d;
        }
        static int dispersion(long x)
        {
            double t;
            int v;
            t = R * x - Math.floor(R * x); // parte decimal
            v = (int)(M * t);
            return v;
        }
        public static void main(string[] a) 
        {
            String clave;
            long valor;
            BufferedReader entrada = new BufferedReader(new InputStreamReader(System.in));
            for(int k = 1; k <= 10; k++)
            {
                System.out.print("\nClave a dispersar: ");
                clave = entrada.readLine();
                valor = transformaClave(clave);
                valor = dispersion(valor);
                System.out.println("Dispersion de la clave " +
                            clave + " \t " + valor);
    }
}


    public class CasaRural
    {
    private String codigo;
    private String poblacion;
    private String direccion;
    private int numHabitacion = 0;
    private double precio = 0.0;
    boolean esAlta;
    public CasaRural()
    {
        esAlta = true;
        asigna();
    }
    Tablas de dispersión, funciones hash 355
    public void asigna()
    {
        BufferedReader entrada = new BufferedReader(
        new InputStreamReader(System.in));
        try
        {
            System.out.print("\n Codigo (10 caracteres): ");
            codigo = entrada.readLine();
            System.out.print("\n Población: ");
            poblacion = entrada.readLine();
            System.out.print("\n Dirección: ");
            direccion = entrada.readLine();
            System.out.print("\n Número de habitaciones: ");
            numHabitacion = Integer.parseInt(entrada.readLine());
            System.out.print("\n Precio por día de estancia: ");
            precio = (new Double(entrada.readLine())).doubleValue();
        }
        catch (IOException e)
        {
            System.out.println(" Excepcion en la entrada de datos " +
            e.getMessage() + " . No se da de alta");
            esAlta = false;
        }
    }
    public String elCodigo()
    {
        return codigo;
    }
    public void muestra()
    {
        System.out.println("\n Casa Rural " + codigo);
        System.out.println("Población: " + poblacion);
        System.out.println("Dirección: " + direccion);
        System.out.println("Precio por día: " + precio);
    }
}
