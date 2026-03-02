using System;

namespace projetobanco
{
	public interface IConversorGrandeza
	{
		decimal converter(decimal valor);
		string ObterSimbolo();
	}
}
