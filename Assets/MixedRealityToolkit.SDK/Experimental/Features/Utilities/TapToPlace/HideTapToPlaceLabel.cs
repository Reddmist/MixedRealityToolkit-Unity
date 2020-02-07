﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Experimental.Utilities
{
    /// <summary>
    /// Class to toggle the visibility of a label on a Tap to Place object in the TapToPlaceExample scene.
    /// </summary>
    public class HideTapToPlaceLabel : MonoBehaviour
    {
        private TapToPlace tapToPlace;
        private GameObject placeableObjectLabel;
        void Start()
        {
            tapToPlace = gameObject.GetComponent<TapToPlace>();
            placeableObjectLabel = gameObject.transform.GetChild(0).gameObject;

            ToggleTapToPlaceLabelVisibility();
        }

        /// <summary>
        /// Add listeners to Tap to Place events to show a label on a placeable object while it is not being placed.
        /// </summary>
        public void ToggleTapToPlaceLabelVisibility()
        {
            if (tapToPlace != null)
            {
                tapToPlace.OnPlacingStarted.AddListener(() =>
                {
                    placeableObjectLabel.SetActive(false);
                });

                tapToPlace.OnPlacingStopped.AddListener(() =>
                {
                    placeableObjectLabel.SetActive(true);
                });
            }
        }
    }
}