class ISController: UsuarioModelo, Ivista{
    public ISController(string CorreoElectronico,string contraseña,string nombre,string FechaNacimiento,string ID):base(CorreoElectronico,contraseña,nombre,FechaNacimiento,ID)
    {}
    //Controlador que va a actuar de acuerdo a las acciones del usuario
    public void Mostrar(){
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("ID de sesion: "+ID);
        Console.WriteLine("Sesion iniciada como:");
        Console.WriteLine("Correo electronico: " +CorreoElectronico);
        Console.WriteLine("Contraseña: " +Contraseña);
        Console.WriteLine("----------------------------------------");
    }

}