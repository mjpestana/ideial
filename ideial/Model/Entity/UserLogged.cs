﻿
namespace ideial.Model.Entity
{
    public static class UserLogged
    {
        //Atributos da classe UserLogged
        public static int IdConta { get; set; }
        public static string User { get; set; }
        public static int IdUtilizador { get; set; }
        public static string NomeUtilizador { get; set; }
        public static string Email { get; set; }
        public static byte[] Foto { get; set; }
        public static string TipoUtilizador { get; set; }
        public static int IdCargo { get; set; }
        public static int IdDepartamento { get; set; }
        public static int IdEmpresa { get; set; }
        public static int Pontuacao { get; set; }
    }
}
