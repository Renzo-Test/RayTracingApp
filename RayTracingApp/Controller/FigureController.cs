﻿using Controller.FigureExceptions;
using IRepository;
using MemoryRepository;
using MemoryRepository.Exceptions;
using Models;
using System;
using System.Collections.Generic;

namespace Controller
{
    public class FigureController
    {
        public IRepositoryFigure Repository;

        public FigureController()
        {
            Repository = new FigureRepository();
        }

        public List<Figure> ListFigures(string username)
        {
            return Repository.GetFiguresByClient(username);
        }

        public void AddFigure(Figure figure, string username)
        {
            try
            {
                RunFigureChecker(figure, username);
                figure.Owner = username;
                Repository.AddFigure(figure);
            }
            catch (InvalidFigureInputException ex)
            {
                throw new InvalidFigureInputException(ex.Message);
            }
        }

        public void RunFigureChecker(Figure figure, string ownerName)
        {
            if (FigureNameExist(figure.Name, ownerName))
            {
                string AlreadyExsitingFigureMessage = $"Figure with name {figure.Name} already exists";
                throw new AlreadyExistingFigureException(AlreadyExsitingFigureMessage);
            }

            FigurePropertiesAreValid(figure);
        }

        public bool FigureNameExist(string name, string ownerName)
        {
            List<Figure> clientFigures = Repository.GetFiguresByClient(ownerName);
            return clientFigures.Find(figure => figure.Name.Equals(name)) is object;
        }

        public void FigurePropertiesAreValid(Figure figure)
        {
            try
            {
                figure.FigurePropertiesAreValid();
            }

            catch (InvalidFigureInputException ex)
            {
                throw new InvalidFigureInputException(ex.Message);
            }
        }
        public void RemoveFigure(string figureName, string username, List<Model> models)
        {
            Figure deleteFigure = Repository.GetFiguresByClient(username).Find(figure => figure.Name.Equals(figureName));

            if (deleteFigure is null)
            {
                string NotFoundFigureMessage = $"Figure with name {figureName} was not found";
                throw new NotFoundFigureException(NotFoundFigureMessage);
            }

            Model foundModel = models.Find(model => model.Figure.Name.Equals(figureName));
            if (foundModel is object)
            {
                string FigureUsedByModelMessage = $"Figure with name {figureName} is used by a model";
                throw new FigureUsedByModelException(FigureUsedByModelMessage);
            }

            Repository.RemoveFigure(deleteFigure);
        }

        public Figure GetFigure(string username, string name)
        {
            Figure getFigure = ListFigures(username).Find(fig => fig.Name.Equals(name));

            if (getFigure is null)
            {
                throw new NotFoundFigureException($"Figure with name {name} was not found");
            }

            return getFigure;
        }
    }
}
