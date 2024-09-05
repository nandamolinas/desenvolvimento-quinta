using System;

namespace API.Models;

public class Produto
{	
	public Produto()
	{
		// C# - construtor
		Id = Guid.NewGuid().ToString();
		CriadoEm = DateTime.Now;
	}
	// C#, Atributo/Propiedade/Caracteristicas. get, set
    public string? Id { get; set;}
	
	public string? Nome { get; set;}

	public double Preco { get; set;}

	public int Quantidade { get; set;}

	public DateTime CriadoEm { get; set;}

    // public double preco {get; set;}
	// Java - atributos , get, set
	// private double preco;
}
