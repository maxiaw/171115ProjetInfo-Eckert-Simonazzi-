﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Activités
{
	public virtual string nomActivite
	{
		get;
		set;
	}

	public static int idActivite
	{
		get;
		set;
	}

	public virtual object heureDebut
	{
		get;
		set;
	}

	public virtual object heureFin
	{
		get;
		set;
	}

	public virtual object texteDescriptif
	{
		get;
		set;
	}

	public virtual string typeActivite
	{
		get;
		set;
	}

	public virtual string statutActivite
	{
		get;
		set;
	}

	public virtual IEnumerable<Astronautes> listeAstronautes
	{
		get;
		set;
	}

	public virtual void RenvoieActiviteParMotCle()
	{
		throw new System.NotImplementedException();
	}

	public virtual void ajouterLieu()
	{
		throw new System.NotImplementedException();
	}

	public virtual void supprimerLieu()
	{
		throw new System.NotImplementedException();
	}

	public virtual void ajouterAstronautes()
	{
		throw new System.NotImplementedException();
	}

	public virtual void supprimerAstronautes()
	{
		throw new System.NotImplementedException();
	}

	public virtual void getListeAstronautes()
	{
		throw new System.NotImplementedException();
	}

	public virtual void getLieu()
	{
		throw new System.NotImplementedException();
	}

}

