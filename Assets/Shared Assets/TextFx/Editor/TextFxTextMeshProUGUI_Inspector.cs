#if UNITY_EDITOR
#if TMP
using Shared_Assets.TextFx.Scripts;
using TMPro.EditorUtilities;
using UnityEditor;
using UnityEngine;

namespace Shared_Assets.TextFx.Editor
{
	[CustomEditor(typeof(TextFxTextMeshProUGUI)), CanEditMultipleObjects]
#if TMP_1_5_1_OR_NEWER
	public class TextFxTextMeshProUGUI_Inspector : TMP_EditorPanelUI
#else
	public class TextFxTextMeshProUGUI_Inspector : TMP_UiEditorPanel
#endif
	{

		TextFxTextMeshProUGUI tmpEffect;
		TextFxAnimationManager animationManager;

		new void OnEnable()
		{
			tmpEffect = (TextFxTextMeshProUGUI) target;
			animationManager = tmpEffect.AnimationManager;

			EditorApplication.update += UpdateManager;

			base.OnEnable ();
		}

		new void OnDisable()
		{
			EditorApplication.update -= UpdateManager;

			base.OnDisable ();
		}

		void UpdateManager()
		{
			TextFxBaseInspector.UpdateManager (animationManager);
		}

		public override void OnInspectorGUI ()
		{
			// Draw TextFx inspector section
			TextFxBaseInspector.DrawTextFxInspectorSection(this, animationManager, ()=> {
				RefreshTextCurveData();
			});

			// Draw default inspector content
			base.OnInspectorGUI();
		}

		new void OnSceneGUI()
		{
			base.OnSceneGUI ();

			if (tmpEffect.RenderToCurve && tmpEffect.BezierCurve.EditorVisible)
			{
				tmpEffect.OnSceneGUIBezier (animationManager.Transform.position, animationManager.Scale * animationManager.AnimationInterface.MovementScale);

				if (GUI.changed)
				{
					RefreshTextCurveData ();
				}
			}
		}

		void RefreshTextCurveData()
		{
			animationManager.CheckCurveData ();

			// Update mesh values to latest using new curve offset values
			tmpEffect.ForceUpdateCachedVertData();


			tmpEffect.UpdateTextFxMesh();
		}
	}
}
#endif
#endif