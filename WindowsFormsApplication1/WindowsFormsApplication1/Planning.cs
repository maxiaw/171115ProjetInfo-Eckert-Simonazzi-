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

public class Planning
{
    private List<Jour> listeDeJours;
    private DateTime dateDebut;
    private string nomPlanning;
    private static int idPlanning;
    //constructeur par défaut
    public Planning(string tempNomPlanning, List<Jour> tempListeDeJour, DateTime tempDateDebut)
    {
        nomPlanning = tempNomPlanning;
        listeDeJours = tempListeDeJour;
        dateDebut = tempDateDebut;
    }
    //Accesseurs//
    public List<Jour> GetListeJour
    {
        get { return listeDeJours;}
        set { listeDeJours = value; }
    }

    public string GetnomPlanning
    {
        get { return nomPlanning; }
        set { nomPlanning = value; }
    }
    public int GetidPlanning
    {
        get { return idPlanning; }
        set { idPlanning = value; }
    }
    //FinAccesseurs//

    // Renvoi le jour de la liste de jour en fonction de l'id.
    public Jour getJourParId (int tempId)
    {

        return listeDeJours[tempId];

    }  
<<<<<<< HEAD
    

	public virtual string nomPlanning
	{
		get;
		set;
	}

	public static object idPlanning
	{
		get;
		set;
	}

	public virtual object tempActuel
	{
		get;
		set;
	}

    public DateTime GetDateDebut
    {
        get { return dateDebut; }
        set { dateDebut = value; }
    }


=======
  
>>>>>>> origin/master
	public virtual int getJourActuel()
	{
        DateTime dateActuelle = new DateTime();
        dateActuelle = DateTime.Now;

        TimeSpan intervalleTemps = dateActuelle - dateDebut;
        double intervalleTempMinute = intervalleTemps.Days * 24 * 60 + intervalleTemps.Hours * 60 + intervalleTemps.Minutes;
        int numeroJourMars = (int)Math.Truncate(intervalleTempMinute /1480);
        return numeroJourMars;
	}

	public virtual void getListeJourPasse()
	{
		throw new System.NotImplementedException();
	}

	public virtual void getListeJourSuivant()
	{
		throw new System.NotImplementedException();
	}

	public virtual void getJourOccupe()
	{
		throw new System.NotImplementedException();
	}

	public virtual void clearActivite()
	{
		throw new System.NotImplementedException();
	}

	public virtual void modifierEtatJour()
	{
		throw new System.NotImplementedException();
	}

	public virtual void rechercheJourParActivite()
	{
		throw new System.NotImplementedException();
	}

	public virtual void rechercheJourParMotCle()
	{
		throw new System.NotImplementedException();
	}

}

