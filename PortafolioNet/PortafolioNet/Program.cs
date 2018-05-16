using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;


namespace PruebaConexionNET
{
    class Program
    {
        //AUTOR    : MARCO ANTONIO MEDINA
        //FECHA    : 04 DE MAYO DEL 2018
        //PROYECTO : EJEMPLOS SIMPLES DE CONEXIÓN A ORACLE

        /*  DOCUMENTACIÓN CONSULTADA: http://www.oracle.com/webfolder/technetwork/tutorials/obe/db/12c/r1/appdev/dotnet/Web_version_Fully_Managed_ODPnet_OBE/odpnetmngdrv.html
            PAQUETE NUGET: Oracle.ManagedDataAccess - https://www.nuget.org/packages/Oracle.ManagedDataAccess/

            Para realizar los proyectos de portafolio, una de las formas de conectarse a ORACLE es utilizando
            un driver llamado ORACLE DATA PROVIDER FOR .NET, o ODP.NET.
            Ahora, ¡en muchos cursos de portafolio los alumnos se han complicado mucho con la conexión
            a ORACLE! ¿Y por qué ocurre esto? Porque no saben buscar documentación en inglés, y mucho
            menos saben qué deben buscar.

            Bueno, en fin, existen dos tipos de ODP.NET, existe un driver "UNMANAGED" y un "MANAGED".
            en rigor, el "UNMANAGED" tiene acceso total a todas las funciones de base de datos, y es más pesado.
            Por otra parte, el "MANAGED" es un simple DLL de no más de 10mb, que cuenta con las funciones más importantes y
            esenciales para hacer, bueno, basicamente todo lo que necesitas.

            Nosotros utilizaremos MANAGED. (Ojo que, ambas versiones funcionan de manera distinta, no usan los mismos comandos)
            */
        static void Main(string[] args)
        {
            /*
             DESCRIPCIÓN DE ESTE PROYECTO:
             En este proyecto mostraré ejemplos simples de SELECT, INSERT Y DELETE, que en rigor, son las operaciones
             más esenciales para generar un CRUD en cualquier proyecto de portafolio.

             NOTA: Si se borran todos los comentarios, se verá todo más claro, este programa igual viene bien comentado
             porque tampoco quiero perder la noción de esto.
             */

            /*
             * -------------------------------------------------
             * ------ CONTENIDOS VISTOS EN ESTE DOCUMENTO ------
             * -------------------------------------------------
             * 
             * 1: CONECTÁNDONOS A LA BASE DE DATOS.
             * 2: EJECUTANDO QUERYS SELECT Y GUARDANDO SUS RESULTADOS EN UN OBJETO. 
             * 3: EJECUTANDO NO-QUERYS, SENTENCIAS QUE NO GENERAN RESULTADOS (INSERT, DETELE, UPDATE, PROCEDIMIENTOS).
             * 3: EJECUTANDO FUNCIONES, QUE ENTREGAN "ESCALARES" (ES DECIR, UN SIMPLE VALOR).
             *
             * -------------------------------------------------
             */

            Console.WriteLine("Conectando ORACLE con .NET");
            Console.WriteLine("Es normal que las transacciones tomen tiempo.");
            try
            {
                //Creamos un string de conexión a ORACLE, en primer instancia definiremos
                //las credenciales de acceso, que en este caso es el usuario de portafolio.
                string conString = "User Id=U_Portafolio; password=PFT201801;" +

                /*
                Ahora, al string de conexión le concatenaremos la ubicación en el servidor.
                OJO ACÁ:
                Así es cómo nos conectamos a una base de datos ORACLE sin configurar un archivo de
                ORACLE que se llama tnsnames.ora.
                Por defecto los tutoriales de internet dirán que te conectes a:
                
                "Data Source=localhost:1521/orcl; Pooling=false;";

                Pero nosotros nos conectamos a:

                "Data Source=localhost:1521/XE; Pooling=false;";

                porque estamos utilizando la versión EXPRESS.
                */

                "Data Source=localhost:1521/XE; Pooling=false;";

                /*Ahora, si algún día, en otra instancia, contaras con un alias de base de datos
                (cosa que en estos proyectos de DUOC es muy poco probable)
                deberías usar esta concatenación:
                
                "Data Source=orcl;Pooling=false;";

                o esta: "Data Source=XE;Pooling=false;";

                dependiendo de qué versión de base de datos uses.
                */

                OracleConnection con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();

                Console.WriteLine(" == CONEXIÓN CON LA BASE DE DATOS, EXITOSA ==");

                /* Creamos un comando dentro del contexto de la conexión,
                La base de datos a utilizar en este ejemplo, es la base de datos de nuestro proyecto
                de portafolio de clínica odontológica (CASO 5 2018/01).

                Todas las modificaciones se harán sobre la tabla PERMISO.
                Porque la tabla permiso es simple.
                 */

                Console.WriteLine(" == EJECUTANDO SENTENCIA SELECT ==");

                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM PERMISO";

                //Ejecutamos el comando y guardaremos todo el resultado en un objeto
                //de tipo OracleDataReader llamado reader, y obtendremos el resultado con el método
                //reader.GetInt32(X) y reader.GetString(X) (hay muchos más tipos, es bien dinámico).
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("ID:" + reader.GetInt32(0) + " - DESCRIPCIÓN: " + reader.GetString(1));
                }

                /*
                El resultado esperado es:
                ID: 0 - DESCRIPCION: MODULO_ADMINISTRADOR
                ID: 1 - DESCRIPCION: MODULO_ODONTOLOGO
                ID: 2 - DESCRIPCION: MODULO_RECEPCIONISTA
                ID: 3 - DESCRIPCION: MODULO_LOGISTICA
                ID: 4 - DESCRIPCION: MODULO_CLIENTE 

                 */

                Console.WriteLine(" == SENTENCIA SELECT, EXITOSA ==");
                con.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : {0}", ex);
                Console.ReadKey();
            }

            try
            {
                //Ahora, ejecutaremos comandos que no generan resultados (INSERT, UPDATE, DELETE, PROCEDIMIENTOS)
                string conString = "User Id=U_Portafolio; password=PFT201801;" + "Data Source=localhost:1521/XE; Pooling=false;";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();
                OracleCommand cmd = con.CreateCommand();

                //Vamos a generar un comando INSERT, que usualmente no debería entregar resultados.

                Console.WriteLine(" == EJECUTANDO SENTENCIA INSERT ==");

                cmd.CommandText = "INSERT INTO PERMISO (ID, DESCRIPCION) VALUES (8, 'MODULO_PRUEBA_CONEXION')";
                //Y acá simplemente se ejecuta con el método ExecuteNonQuery(), sin el reader.
                cmd.ExecuteNonQuery();

                //El resultado esperado es: Nada, asi que simplemente notificaremos con un mensaje.
                Console.WriteLine("== INSERCIÓN REALIZADA CON ÉXITO ==");
                con.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : {0}", ex);
                Console.ReadKey();
            }

            /*
             Ahora, un nuevo select debería entregar esto:

                ID: 8 - DESCRIPCION: MODULO_PRUEBA_CONEXION <-- Nuestro nuevo registro
                ID: 0 - DESCRIPCION: MODULO_ADMINISTRADOR
                ID: 1 - DESCRIPCION: MODULO_ODONTOLOGO
                ID: 2 - DESCRIPCION: MODULO_RECEPCIONISTA
                ID: 3 - DESCRIPCION: MODULO_LOGISTICA
                ID: 4 - DESCRIPCION: MODULO_CLIENTE

             */

            try
            {
                string conString = "User Id=U_Portafolio; password=PFT201801;" +"Data Source=localhost:1521/XE; Pooling=false;";

                OracleConnection con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();

                Console.WriteLine(" == EJECUTANDO SENTENCIA SELECT ==");

                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM PERMISO";
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("ID:" + reader.GetInt32(0) + " - DESCRIPCIÓN: " + reader.GetString(1));
                }
                Console.WriteLine(" == SENTENCIA SELECT, EXITOSA ==");
                con.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : {0}", ex);
                Console.ReadKey();
            }

            try
            {
                //Ahora, quiero eliminar el registro nuevo.
                string conString = "User Id=U_Portafolio; password=PFT201801;" + "Data Source=localhost:1521/XE; Pooling=false;";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();
                OracleCommand cmd = con.CreateCommand();

                Console.WriteLine(" == EJECUTANDO SENTENCIA DELETE, PARA DESHACER EL CAMBIO ==");

                cmd.CommandText = "DELETE FROM PERMISO WHERE ID = 8";
                cmd.ExecuteNonQuery();

                Console.WriteLine("== DELECIÓN REALIZADA CON ÉXITO ==");
                con.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : {0}", ex);
                Console.ReadKey();
            }

            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();

            /* FINALMENTE, SI DESEO EJECUTAR UNA FUNCIÓN ALMACENADA:
             
            Las funciones entregan valores que se conocen como escalares, entonces, simplemente ejecutas esto y ya,
            el valor de la función se guarda en una variable. (Asumiento que la función entregó un INT).

            try
            {
                string conString = "User Id=U_Portafolio; password=PFT201801;" + "Data Source=localhost:1521/XE; Pooling=false;";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();
                OracleCommand cmd = con.CreateCommand();

                cmd.CommandText = "SELECT FN_UNAFUNCION(PARAMETRO)";
                Int32 resultado = (Int32) = Convert.ToInt32( cmd.ExecuteScalar() );
                Console.WriteLine("El resultado de la función es: " + resultado);

                con.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : {0}", ex);
                Console.ReadKey();
            }


             */
        }
    }
}
