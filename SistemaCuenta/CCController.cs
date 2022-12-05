class CCController: UsuarioModelo, Ivista{
    public CCController(string CorreoElectronico,string contraseña,string nombre,string FechaNacimiento,string ID):base(CorreoElectronico,contraseña,nombre,FechaNacimiento,ID)
    {}
    //Controlador que va a actuar de acuerdo a las acciones del usuario
    public void Mostrar(){
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("ID de registro:" +ID);
        Console.WriteLine("Cuenta registrada:");
        Console.WriteLine("Correo electronico: " +CorreoElectronico);
        Console.WriteLine("Fecha de nacimiento: "+FechaNacimiento);
        Console.WriteLine("Contraseña: "+Contraseña);   
        Console.WriteLine("Confirmar contraseña: " +Contraseña);
        Console.WriteLine("----------------------------------------");
    }

}