class UsuarioModelo{

    //Modelo - Contiene los datos que se utilizaran en la ejecucion del software
    public string? CorreoElectronico { get; set; }
    public string? Contraseña { get; set; }
    public string? Nombre { get; set; }
    public string? FechaNacimiento { get; set; }
    public string? ID { get; set; }

    public UsuarioModelo(string CorreoElectronico,string Contraseña, string Nombre,string FechaNacimiento,string ID){
        this.CorreoElectronico=CorreoElectronico;
        this.Contraseña=Contraseña;
        this.Nombre=Nombre;
        this.FechaNacimiento=FechaNacimiento;
        this.ID=ID;
    }
}