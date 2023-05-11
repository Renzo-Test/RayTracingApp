﻿using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly : InternalsVisibleTo("Test")]

namespace Domain
{
	public class Scene
	{
		private const string EmptyNameMessage = "Scene's name must not be empty";
		private const string SpaceCharacterConstant = " ";
		private const string StartOrEndWithSpaceMessage = "Scene's name must not start or end with blank space";
		private const int MinFov = 1;
		private const int MaxFov = 160;
		private string _owner;
		private string _name;
		public string _registerTime = DateTime.Now.ToString("hh:mm:ss - dd/MM/yyyy");
		private string _lastModificationDate = "unmodified";
		private string _lastRenderDate = "unrendered";
		private int _fov;
		public Vector CameraPosition = new Vector();
		public Vector ObjectivePosition = new Vector();
		public List<PosisionatedModel> PosisionatedModels;
		private static int _createdSceneCounter = 0;
		private int _sceneNumber;

		public Scene(string owner, int fov, Vector lookFrom, Vector lookAt) 
		{
			_sceneNumber = ++_createdSceneCounter;
			_name = $"Blank Scene {_sceneNumber}";
			_owner = owner;
			_fov = fov;
			CameraPosition = lookFrom;
			ObjectivePosition = lookAt;
			PosisionatedModels = new List<PosisionatedModel>();
		}

        public Scene()
        {
        }

        public string Owner
		{
			get => _owner;
			set => _owner = value;
		}
		public string Name
		{
			get => _name;
			set
			{
				try
				{
					RunNameIsEmptyChecker(value);
					RunNameIsSpacedChecker(value);
					_name = value;
				}
				catch (InvalidSceneInputException ex)
				{
					throw new InvalidSceneInputException(ex.Message);
				}
			}
		}
		public string RegisterTime
		{
			get => _registerTime;
			set => _registerTime = DateTime.Now.ToString("hh:mm:ss - dd/MM/yyyy");
		}
		public string LastModificationDate
		{
			get => _lastModificationDate;
			set => _lastModificationDate = value;
		}
		public string LastRenderDate
		{
			get => _lastRenderDate;
			set => _lastRenderDate = value;
		}
		public int Fov
		{
			get => _fov;
			set
			{
				try
				{
					RunFovIsValidChecker(value);
					_fov = value;
				}
				catch (InvalidSceneInputException ex)
				{
					throw new InvalidSceneInputException(ex.Message);
				}
			}
		}

		private static void RunNameIsEmptyChecker(string value)
		{
			if (value.Equals(string.Empty))
			{
				throw new EmptyNameSceneException(EmptyNameMessage);
			}
		}

		private static void RunNameIsSpacedChecker(string value)
		{
			if (value.StartsWith(SpaceCharacterConstant) || value.EndsWith(SpaceCharacterConstant))
			{
				throw new InvalidSpacePositionException(StartOrEndWithSpaceMessage);
			}
		}

		private static void RunFovIsValidChecker(int value)
		{
			if (!Enumerable.Range(MinFov, MaxFov).Contains(value))
			{
				throw new InvalidFovException($"Scene's fov must be between {MinFov} and {MaxFov}");
			}
		}

		internal void ResetCreatedCounter()
		{
			_createdSceneCounter = 0;
		}
	}
}
