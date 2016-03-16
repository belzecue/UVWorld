using UnityEngine;
using System.Collections;

namespace UVWorld {

    public abstract class AbstractUVWorld : MonoBehaviour {
        public Vector2 extrude = Vector2.one;

        public abstract bool World (Vector2 uv, out Vector3 pos, out Vector3 normal);

        protected Vector2 Extrude(Vector2 uv) {
            return new Vector3 (
                extrude.x * (uv.x - 0.5f) + 0.5f,
                extrude.y * (uv.y - 0.5f) + 0.5f);
        }
    }
}
