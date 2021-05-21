using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev.Character
{
    /// <summary>
    /// キャラクタクラス
    /// </summary>
    public abstract class Character : MonoBehaviour
    {
        /// <summary>
        /// Componentリスト
        /// </summary>
        private List<CharacterComponent> Components = new List<CharacterComponent>();

        /// <summary>
        /// キャラクタコンポーネント追加
        /// </summary>
        /// <param name="Component">キャラクタコンポーネント</param>
        protected void AddCharacterComponent(CharacterComponent Component)
        {
            Components.Add(Component);
        }

        void Update()
        {
            foreach (var Component in Components)
            {
                Component.OnUpdate();
            }
        }

        void FixedUPdate()
        {
            foreach (var Component in Components)
            {
                Component.OnFixedUpdate();
            }
        }
    }
}
