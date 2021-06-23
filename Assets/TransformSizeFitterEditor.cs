using UnityEditor;
using UnityEditor.UI;
using UnityEngine;

[CustomEditor(typeof(TransformSizeFitter))]
[CanEditMultipleObjects]
public class TransformSizeFitterEditor : ContentSizeFitterEditor
{
	SerializedProperty fitRect;

	protected override void OnEnable()
	{
		base.OnEnable();

		fitRect = serializedObject.FindProperty("fitRect");
	}

	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI();

		EditorGUILayout.PropertyField(fitRect, new GUIContent("Fit Rect"));

		serializedObject.ApplyModifiedProperties();
	}
}
