using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/*[CustomPropertyDrawer(typeof(SceneField))]
public class SceneFieldPropertyDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, GUIContent.none, property);
        SerializedProperty sceneAsset = property.FindPropertyRelative("m_SceneAsset");
        SerializedProperty sceneName = property.FindPropertyRelative("m_SceneName");

        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
        if (sceneAsset != null)
        {
            sceneAsset.objectReferenceValue = EditorGUI.ObjectField(position, sceneAsset.objectReferenceValue, typeof(SceneAsset), false);
            if (sceneAsset.objectReferenceValue != null)
                sceneName.stringValue = (sceneAsset.objectReferenceValue as SceneAsset).name;
        }

        EditorGUI.EndProperty();
    }
}
*/