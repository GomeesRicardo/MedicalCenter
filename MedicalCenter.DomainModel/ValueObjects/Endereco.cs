using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalCenter.DomainModel.ValueObjects
{
    public struct Endereco
    {
        public string Rua { get; set; }
        public string Numero { get; set; }

        public Endereco(String rua, String numero)
        {
           if(string.IsNullOrEmpty(rua))
                throw new ArgumentOutOfRangeException("Rua", "Indique o nome da rua");

            if (string.IsNullOrEmpty(numero))
                throw new ArgumentOutOfRangeException("Rua", "Indique o número da rua");

            Rua = rua;
            Numero = numero;
        }

        public static Endereco NovoEndereco(String rua, String numero)
        {
            return new Endereco(rua, numero);
        }

        public static Endereco Parse(string enderecoStr)
        {
            var splittedEndereco = enderecoStr.Split(',');
            String rua = splittedEndereco[0];
            String numero = splittedEndereco[1];
            return new Endereco(rua, numero);
        }

        public static bool operator ==(Endereco endereco, Endereco endereco2)
        {
            if (endereco.Rua + endereco.Numero == endereco2.Rua + endereco2.Numero)
                return true;
            return false;
        }

        public static bool operator !=(Endereco endereco, Endereco endereco2)
        {
            if (endereco.Rua + endereco.Numero != endereco2.Rua + endereco2.Numero)
                return true;
            return false;
        }

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            var end = this.Rua + this.Numero;
            return end.GetHashCode();
        }

        public override string ToString()
        {
            var end = this.Rua + this.Numero;
            return end;
        }
    }
}
