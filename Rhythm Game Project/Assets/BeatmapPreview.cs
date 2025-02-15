﻿namespace Menu
{
    using UnityEngine;
    using UnityEngine.UI;
    using Audio;

    public sealed class BeatmapPreview : MonoBehaviour
    {
        #region Private Fields
        [SerializeField] private Image backgroundImage = default;
        #endregion

        #region Public Methods
        public void SetBackgroundImage(Texture _imageTexture)
        {
            backgroundImage.gameObject.SetActive(false);
            backgroundImage.material.mainTexture = _imageTexture;
            backgroundImage.gameObject.SetActive(true);
        }
        #endregion
    }
}
