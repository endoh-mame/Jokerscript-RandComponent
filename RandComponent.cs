using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Novel{
	public class RandComponent:AbstractComponent{
		public RandComponent (){
			this.arrayVitalParam = new List<string> {
				"var", "min", "max"
			};
			this.originalParam = new Dictionary<string,string> () {
				{"var",""}, 
				{"min",""}, 
				{"max",""}
			};
		}

		public override void start (){
			string varName = this.param ["var"];
			float min = float.Parse(this.param ["min"]);
			float max = float.Parse(this.param ["max"]);
			float rand = Random.Range(min, max + 1);
			string randStr = ((int)rand).ToString();
			string exp = "f." + varName + "=" + randStr;
			// Debug.Log(exp);
			// string exp = "f.test=500";

			ExpObject eo = new ExpObject (exp);
			string result = ExpObject.calc (eo.exp);
			StatusManager.variable.set(eo.type+"."+eo.name, result);
			this.gameManager.nextOrder ();
		}
	}
}