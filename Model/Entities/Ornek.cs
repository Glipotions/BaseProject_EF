﻿using Model.Attributes;
using Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
	public class Ornek:BaseEntityDurum
	{
		[Index("IX_Kod", IsUnique = true)]
		public override string Kod { get; set; }
		[Required, StringLength(50), ZorunluAlan("Bilgi Adı", "txtBilgiAdi")]
		public string BilgiAdi { get; set; }
		[StringLength(500)]
		public string Aciklama { get; set; }
	}
}