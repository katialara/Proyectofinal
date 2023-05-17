using System;
using System.Data; // Using importantes para establecer la conexión 
using System.Data.SqlClient; // Using importantes para establecer la conexión 
using System.Windows.Forms; // Using importante para mostrar mensaje en pantalla (Messabox.Show)

class Conexion
    {
        SqlConnection cn; // Variable que nos permite crear la conexión
        SqlCommand cmd; // Variable que nos servirá para poder insertar, eliminar, consultar y modificar 
             SqlDataReader dr; // Variable que no usaremos en este post, pero sirve para leer consultas sql
        SqlDataAdapter adaptador; // Variable que no usaremos en este post pero sirve para llenar un grid
        DataSet ds; // Variable que no usaremos en este post pero sirve para llenar un grid
       
    public Conexion()
            {
                try
                    {
                        //Se crea la variable SqlConnection y se le asigna la cadena de conexión
            //LIM0686-778516\\SQLEXPRESS corresponde al nombre de la instancia de SQL SERVER  
                        //Deberán sustituirlo por el nombre de su instancia, mas abajo les enseñaré a como extraer este dato
            //MATRICULA deberán sustituirlo por el nombre de sus bases de datos          
                       
            cn = new SqlConnection("Data Source=LAPTOP-HAO3D8QC\\SQLEXPRESS;Initial Catalog=ProyectoCompilador;Integrated Security=True");
                        cn.Open(); // En esta linea se abre la conexión
                        MessageBox.Show("Conectado"); // Se muestra el mensaje en caso que se haya conectado
                    }
                catch (Exception ex)
                        {
                        //En caso que no se pueda realizar la conexión se captura el error en el Cacth y se muestra un
                                    //mensaje. El comando ex.ToString() indica el motivo por el cual sucedió el error
            MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());

        }

    }

    public string RegistrarUsuario(string IdUsuario, string Nombre, string Correo, string Telefono, string Contrasenia)
            {
                string salida = "Se registró el usuario correctamente";
                try
                    {
            //La sentencia a continuación, insertar en la Tabla Profesor los valores pasados como parámetros         
            cmd = new SqlCommand("Insert into Signin(IdUsuario,Nombre,Correo,Telefono,Contrasenia) values ('" + IdUsuario + "','" + Nombre + "','" + Correo + "'," + Telefono + "'," + Contrasenia + ")", cn);
                        cmd.ExecuteNonQuery(); // Sentencia que ejecuta el comando Sql definido en la linea anterior
                    }
                catch (Exception ex)
                        {
                        salida = "No se inserto: " + ex.ToString(); // 
                    }
                return salida;

    }

}
