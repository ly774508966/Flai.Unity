﻿using System.Collections.Generic;
using Flai.DataStructures;
// ReSharper disable ConvertConditionalTernaryToNullCoalescing
using UnityEngine;
using SystemObject = System.Object;

namespace Flai
{
    public abstract class FlaiScript : MonoBehaviour
    {
        private GameObject _gameObject = null;
        private Transform _transform = null;

        public GameObject GameObject
        {
            get { return _gameObject == null ? (_gameObject = gameObject) : _gameObject; }
        }

        public Transform Transform
        {
            get { return _transform == null ? (_transform = transform) : _transform; }
        }

        public Vector2f Position2D
        {
            get { return this.Transform.GetPosition2D(); }
            set { this.Transform.SetPosition2D(value); }
        }

        public Vector2 LocalPosition2D
        {
            get { return this.Transform.GetPosition2D(); }
            set { this.Transform.SetPosition2D(value); }
        }

        public Vector3 Position
        {
            get { return this.Transform.position; }
            set { this.Transform.position = value; }
        }

        public float Rotation2D
        {
            get { return this.Transform.GetRotation2D(); }
            set { this.Transform.SetRotation2D(value); }
        }

        public float LocalRotation2D
        {
            get { return this.Transform.GetLocalRotation2D(); }
            set { this.Transform.SetRotation2D(value); }
        }

        public Vector3 Rotation
        {
            get { return this.Transform.eulerAngles; }
            set { this.Transform.eulerAngles = value; }
        }

        public Vector3 LocalRotation
        {
            get { return this.Transform.localEulerAngles; }
            set { this.Transform.localEulerAngles = value; }
        }

        public Quaternion RotationQuaternion
        {
            get { return this.Transform.rotation; }
            set { this.Transform.rotation = value; }
        }

        public Quaternion LocalRotationQuaternion
        {
            get { return this.Transform.localRotation; }
            set { this.Transform.localRotation = value; }
        }

        public Vector2f Scale2D
        {
            get { return this.Transform.GetScale2D(); }
            set { this.Transform.SetScale2D(value); }
        }

        public Vector3 Scale
        {
            get { return this.Transform.localScale; }
            set { this.Transform.localScale = value; }
        }

        public GameObject Parent
        {
            get { return this.Transform.parent.gameObject; }
        }

        public IEnumerable<GameObject> Children
        {
            get { return this.GetAllChildren(); }
        }

        protected FlaiScript()
        {
        }

        protected virtual void Awake() { }
        protected virtual void Start() { }

        protected virtual void Update() { }
        protected virtual void FixedUpdate() { }
        protected virtual void LateUpdate() { }

        protected virtual void OnCollisionEnter2D(Collision2D collision) { }
        protected virtual void OnCollisionStay2D(Collision2D collision) { }
        protected virtual void OnCollisionExit2D(Collision2D collision) { }

        protected virtual void OnTriggerEnter2D(Collider2D other) { }
        protected virtual void OnTriggerStay2D(Collider2D other) { }
        protected virtual void OnTriggerExit2D(Collider2D other) { }

        protected virtual void OnDrawGizmos() { }
    }
}