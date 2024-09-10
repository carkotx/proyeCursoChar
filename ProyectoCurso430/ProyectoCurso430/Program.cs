
public class Usuario
{
    public int Id;
    public string Nombre;
    public string Apellido;
    public string NombreUsuario;
    public string Contraseña;
    public string Mail;          
}

// Clase Producto
public class Producto
{
    public int Id;
    public string Descripcion;
    public decimal Costo;
    public decimal PrecioVenta;
    public int Stock;
    public int IdUsuario;     
}

// Clase ProductoVendido
public class ProductoVendido
{
    public int Id;
    public int IdProducto;
    public int Stock;
    public int IdVenta;
}

// Clase Venta
public class Venta
{
    public int Id;
    public string Comentarios;
    public int IdUsuario;   
}