﻿namespace JustPoChess.Client.MVC.Model.Contracts
{
    public interface IPosition
    {
        int Row { get; set; }
        int Col { get; set; }
    }
}