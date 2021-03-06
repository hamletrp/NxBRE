namespace org.nxbre.ie.adapters {

	using System;
	using System.Collections;
	
	/// <summary>
	/// NxBRE Inference Engine rulebase adapter interface.
	/// The engine calls the properties in this order: Binder, Direction, Label, Queries, Implications, Facts.
	/// </summary>
	/// <description>Reading is supported by the getter of each member, while writing is supported by setters.
	/// The engine calls dispose at the end of the load or save operation.
	/// </description>
	/// <see cref="org.nxbre.ie.IEImpl"/>
	/// <author>David Dossot</author>
	public interface IRuleBaseAdapter:IFactBaseAdapter {
		
		/// <summary>
		/// Collection containing all the queries in the rulebase.
		/// </summary>
		ArrayList Queries {
			get;
			set;
		}
		
		/// <summary>
		/// Collection containing all the implications in the rulebase.
		/// </summary>
		ArrayList Implications {
			get;
			set;
		}
		
	}
}
