using UnityEngine;

using System.Collections;

using System.Collections.Generic;

using UnityEngine.UI;



// Unity5.3.4p4



namespace TSKT

{

    [RequireComponent(typeof(Text))]

    public class Vibrate : BaseMeshEffect

    {

        const float Interval = 0.067f;

        float lastModifiedTime = 0f;

        List<UIVertex> vertices = new List<UIVertex>();



        public override void ModifyMesh(VertexHelper vh)

        {

            if (!IsActive())

            {

                return;

            }



            vh.GetUIVertexStream(vertices);

            ModifyMesh(vertices);

            vh.Clear();

            vh.AddUIVertexTriangleStream(vertices);

        }



        void ModifyMesh(List<UIVertex> list)

        {

            for (int i = 0; i < list.Count; i += 6)

            {

                var distance = Random.insideUnitSphere * 4f;

                for (int j = 0; j < 6; ++j)

                {

                    var vertex = list[i + j];

                    vertex.position = vertex.position + distance;

                    list[i + j] = vertex;

                }

            }

        }



        Text text;

        Text Text

        {

            get

            {

                return text ?? (text = GetComponent<Text>());

            }

        }



        void Update()

        {

            if (Time.time - lastModifiedTime >= Interval)

            {

                lastModifiedTime = Time.time;

                Text.SetAllDirty();

            }

        }

    }

}