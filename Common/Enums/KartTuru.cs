using System.ComponentModel;

namespace Common.Enums
{
	public enum KartTuru : byte
	{
		[Description("Örnek Kartı")]
		Ornek = 1,
		[Description("Filtre Kartı")]
		Filtre = 2,
	}
}
