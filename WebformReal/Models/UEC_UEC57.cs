using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;

namespace WebformReal.Models
{
	public class UEC_UEC57
	{
		public int UEC_UEC57_Alam_id { get; set; }
		[Required]
		public string UEC_UEC57_Alam_UnitName { get; set; }
		[Required]
		public string UEC_UEC57_Alam_UnitDescription { get; set; }
		public string UEC_UEC57_Alam_BuiltAsDesign { get; set; }
		public string UEC_UEC57_Alam_IOW { get; set; }
		public string UEC_UEC57_Alam_BasedLineInspection { get; set; }
		public string UEC_UEC57_Alam_CompliancewithCMM { get; set; }
		public string UEC_UEC57_Alam_Inspection { get; set; }
		public string UEC_UEC57_Alam_NoTemporaryRepair { get; set; }
		public string UEC_UEC57_Alam_CompliancetoPerformanceStandard { get; set; }
		public string UEC_UEC57_Alam_FSR { get; set; }
		public string UEC_UEC57_Alam_RiskRanking { get; set; }
		public string UEC_UEC57_Alam_RiskLevel { get; set; }
		public string UEC_UEC57_Alam_CurrentStatus { get; set; }
		public string UEC_UEC57_Alam_Threats { get; set; }
		public string UEC_UEC57_Alam_Probability { get; set; }
		public string UEC_UEC57_Alam_Consequence { get; set; }

		//Start of CRUD functions

		string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

		//CRUD FUNCTIONS FOR UEC_UEC57_Alam
		public List<UEC_UEC57> AlamgetData()
		{
			List<UEC_UEC57> dataList = new List<UEC_UEC57>();

			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("select * from dbo.Alam order by id", con);

			con.Open();
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				UEC_UEC57 data = new UEC_UEC57();
				data.UEC_UEC57_Alam_id = Convert.ToInt32(dr.GetValue(0).ToString());
				data.UEC_UEC57_Alam_UnitName = dr.GetValue(1).ToString();
				data.UEC_UEC57_Alam_UnitDescription = dr.GetValue(2).ToString();

				data.UEC_UEC57_Alam_BuiltAsDesign = dr.GetValue(3).ToString();
				data.UEC_UEC57_Alam_IOW = dr.GetValue(4).ToString();
				data.UEC_UEC57_Alam_BasedLineInspection = dr.GetValue(5).ToString();
				data.UEC_UEC57_Alam_CompliancewithCMM = dr.GetValue(6).ToString();
				data.UEC_UEC57_Alam_Inspection = dr.GetValue(7).ToString();
				data.UEC_UEC57_Alam_NoTemporaryRepair = dr.GetValue(8).ToString();
				data.UEC_UEC57_Alam_CompliancetoPerformanceStandard = dr.GetValue(9).ToString();
				data.UEC_UEC57_Alam_FSR = dr.GetValue(10).ToString();
				data.UEC_UEC57_Alam_RiskLevel = dr.GetValue(11).ToString();
				data.UEC_UEC57_Alam_CurrentStatus = dr.GetValue(12).ToString();
				data.UEC_UEC57_Alam_Threats = dr.GetValue(13).ToString();
				data.UEC_UEC57_Alam_Probability = dr.GetValue(14).ToString();
				data.UEC_UEC57_Alam_Consequence = dr.GetValue(15).ToString();

				dataList.Add(data);
			}

			con.Close();


			return dataList;
		}
		public bool AlamAddData(UEC_UEC57 data)
		{

			SqlConnection con = new SqlConnection(cs);

			SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Alam(UnitName, UnitDescription, BuiltAsDesign, IOW, BasedLineInspection, CompliancewithCMM, Inspection, NoTemporaryRepair, CompliancetoPerformanceStandard, FSR, RiskLevel, CurrentStatus,Threats, Probability, Consequence)VALUES(@UnitName, @UnitDescription, @BuiltAsDesign, @IOW, @BasedLineInspection, @CompliancewithCMM,	 @Inspection, @NoTemporaryRepair, @CompliancetoPerformanceStandard, @FSR,  @RiskLevel, @CurrentStatus, @Threats, @Probability, @Consequence)", con);


			cmd.Parameters.AddWithValue("@UnitName", data.UEC_UEC57_Alam_UnitName);
			cmd.Parameters.AddWithValue("@UnitDescription", data.UEC_UEC57_Alam_UnitDescription);
			cmd.Parameters.AddWithValue("@BuiltAsDesign", data.UEC_UEC57_Alam_BuiltAsDesign);
			cmd.Parameters.AddWithValue("@IOW", data.UEC_UEC57_Alam_IOW);
			cmd.Parameters.AddWithValue("@BasedLineInspection", data.UEC_UEC57_Alam_BasedLineInspection);
			cmd.Parameters.AddWithValue("@CompliancewithCMM", data.UEC_UEC57_Alam_CompliancewithCMM);
			cmd.Parameters.AddWithValue("@Inspection", data.UEC_UEC57_Alam_Inspection);
			cmd.Parameters.AddWithValue("@NoTemporaryRepair", data.UEC_UEC57_Alam_NoTemporaryRepair);
			cmd.Parameters.AddWithValue("@CompliancetoPerformanceStandard", data.UEC_UEC57_Alam_CompliancetoPerformanceStandard);
			cmd.Parameters.AddWithValue("@FSR", data.UEC_UEC57_Alam_FSR);

			cmd.Parameters.AddWithValue("@RiskLevel", data.UEC_UEC57_Alam_RiskLevel);
			if (data.UEC_UEC57_Alam_CurrentStatus != null)
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", data.UEC_UEC57_Alam_CurrentStatus);
			}
			else
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", "");
			}
			if (data.UEC_UEC57_Alam_Threats != null)
			{
				cmd.Parameters.AddWithValue("@Threats", data.UEC_UEC57_Alam_Threats);
			}
			else
			{
				cmd.Parameters.AddWithValue("@Threats", "");
			}
			cmd.Parameters.AddWithValue("@Probability", data.UEC_UEC57_Alam_Probability);
			cmd.Parameters.AddWithValue("@Consequence", data.UEC_UEC57_Alam_Consequence);


			con.Open();
			int i = cmd.ExecuteNonQuery();


			con.Close();
			if (i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}
		public bool AlamUpdateData(UEC_UEC57 data)
		{
			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("UPDATE dbo.Alam SET UnitName = @UnitName,UnitDescription = @UnitDescription ,BuiltAsDesign = @BuiltAsDesign ,IOW = @IOW    ,BasedLineInspection = @BasedLineInspection    ,CompliancewithCMM = @CompliancewithCMM   ,Inspection = @Inspection    ,NoTemporaryRepair = @NoTemporaryRepair    ,CompliancetoPerformanceStandard = @CompliancetoPerformanceStandard     ,FSR = @FSR , RiskLevel=@RiskLevel,CurrentStatus=@CurrentStatus,Threats=@Threats,Probability=@Probability,Consequence=@Consequence WHERE id=@id", con);
			UEC_UEC57_Alam_id = data.UEC_UEC57_Alam_id;
			cmd.Parameters.AddWithValue("@id", data.UEC_UEC57_Alam_id);

			cmd.Parameters.AddWithValue("@UnitName", data.UEC_UEC57_Alam_UnitName);
			cmd.Parameters.AddWithValue("@UnitDescription", data.UEC_UEC57_Alam_UnitDescription);
			cmd.Parameters.AddWithValue("@BuiltAsDesign", data.UEC_UEC57_Alam_BuiltAsDesign);
			cmd.Parameters.AddWithValue("@IOW", data.UEC_UEC57_Alam_IOW);
			cmd.Parameters.AddWithValue("@BasedLineInspection", data.UEC_UEC57_Alam_BasedLineInspection);
			cmd.Parameters.AddWithValue("@CompliancewithCMM", data.UEC_UEC57_Alam_CompliancewithCMM);
			cmd.Parameters.AddWithValue("@Inspection", data.UEC_UEC57_Alam_Inspection);
			cmd.Parameters.AddWithValue("@NoTemporaryRepair", data.UEC_UEC57_Alam_NoTemporaryRepair);
			cmd.Parameters.AddWithValue("@CompliancetoPerformanceStandard", data.UEC_UEC57_Alam_CompliancetoPerformanceStandard);
			cmd.Parameters.AddWithValue("@FSR", data.UEC_UEC57_Alam_FSR);

			cmd.Parameters.AddWithValue("@RiskLevel", data.UEC_UEC57_Alam_RiskLevel);
			if (data.UEC_UEC57_Alam_CurrentStatus != null)
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", data.UEC_UEC57_Alam_CurrentStatus);
			}
			else
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", "");
			}
			if (data.UEC_UEC57_Alam_Threats != null)
			{
				cmd.Parameters.AddWithValue("@Threats", data.UEC_UEC57_Alam_Threats);
			}
			else
			{
				cmd.Parameters.AddWithValue("@Threats", "");
			}
			cmd.Parameters.AddWithValue("@Probability", data.UEC_UEC57_Alam_Probability);
			cmd.Parameters.AddWithValue("@Consequence", data.UEC_UEC57_Alam_Consequence);


			con.Open();
			int i = cmd.ExecuteNonQuery();
			cmd.Dispose();

			con.Close();
			if (i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}
		public bool AlamDeleteData(int id)
		{
			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("delete from Alam where id=@id", con);

			cmd.Parameters.AddWithValue("@id", id);
			con.Open();
			int i = cmd.ExecuteNonQuery();
			cmd.Dispose();

			con.Close();
			if (i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}

		//CRUD FUNCTIONS FOR UEC_UEC57_Amal
		public List<UEC_UEC57> AmalgetData()
		{
			List<UEC_UEC57> dataList = new List<UEC_UEC57>();

			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("select * from dbo.Amal order by id", con);

			con.Open();
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				UEC_UEC57 data = new UEC_UEC57();
				data.UEC_UEC57_Alam_id = Convert.ToInt32(dr.GetValue(0).ToString());
				data.UEC_UEC57_Alam_UnitName = dr.GetValue(1).ToString();
				data.UEC_UEC57_Alam_UnitDescription = dr.GetValue(2).ToString();

				data.UEC_UEC57_Alam_BuiltAsDesign = dr.GetValue(3).ToString();
				data.UEC_UEC57_Alam_IOW = dr.GetValue(4).ToString();
				data.UEC_UEC57_Alam_BasedLineInspection = dr.GetValue(5).ToString();
				data.UEC_UEC57_Alam_CompliancewithCMM = dr.GetValue(6).ToString();
				data.UEC_UEC57_Alam_Inspection = dr.GetValue(7).ToString();
				data.UEC_UEC57_Alam_NoTemporaryRepair = dr.GetValue(8).ToString();
				data.UEC_UEC57_Alam_CompliancetoPerformanceStandard = dr.GetValue(9).ToString();
				data.UEC_UEC57_Alam_FSR = dr.GetValue(10).ToString();
				data.UEC_UEC57_Alam_RiskLevel = dr.GetValue(11).ToString();
				data.UEC_UEC57_Alam_CurrentStatus = dr.GetValue(12).ToString();
				data.UEC_UEC57_Alam_Threats = dr.GetValue(13).ToString();
				data.UEC_UEC57_Alam_Probability = dr.GetValue(14).ToString();
				data.UEC_UEC57_Alam_Consequence = dr.GetValue(15).ToString();

				dataList.Add(data);
			}

			con.Close();


			return dataList;
		}
		public bool AmalAddData(UEC_UEC57 data)
		{

			SqlConnection con = new SqlConnection(cs);

			SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Amal(UnitName, UnitDescription, BuiltAsDesign, IOW, BasedLineInspection, CompliancewithCMM, Inspection, NoTemporaryRepair, CompliancetoPerformanceStandard, FSR, RiskLevel, CurrentStatus,Threats, Probability, Consequence)VALUES(@UnitName, @UnitDescription, @BuiltAsDesign, @IOW, @BasedLineInspection, @CompliancewithCMM,	 @Inspection, @NoTemporaryRepair, @CompliancetoPerformanceStandard, @FSR,  @RiskLevel, @CurrentStatus, @Threats, @Probability, @Consequence)", con);


			cmd.Parameters.AddWithValue("@UnitName", data.UEC_UEC57_Alam_UnitName);
			cmd.Parameters.AddWithValue("@UnitDescription", data.UEC_UEC57_Alam_UnitDescription);
			cmd.Parameters.AddWithValue("@BuiltAsDesign", data.UEC_UEC57_Alam_BuiltAsDesign);
			cmd.Parameters.AddWithValue("@IOW", data.UEC_UEC57_Alam_IOW);
			cmd.Parameters.AddWithValue("@BasedLineInspection", data.UEC_UEC57_Alam_BasedLineInspection);
			cmd.Parameters.AddWithValue("@CompliancewithCMM", data.UEC_UEC57_Alam_CompliancewithCMM);
			cmd.Parameters.AddWithValue("@Inspection", data.UEC_UEC57_Alam_Inspection);
			cmd.Parameters.AddWithValue("@NoTemporaryRepair", data.UEC_UEC57_Alam_NoTemporaryRepair);
			cmd.Parameters.AddWithValue("@CompliancetoPerformanceStandard", data.UEC_UEC57_Alam_CompliancetoPerformanceStandard);
			cmd.Parameters.AddWithValue("@FSR", data.UEC_UEC57_Alam_FSR);

			cmd.Parameters.AddWithValue("@RiskLevel", data.UEC_UEC57_Alam_RiskLevel);
			if (data.UEC_UEC57_Alam_CurrentStatus != null)
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", data.UEC_UEC57_Alam_CurrentStatus);
			}
			else
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", "");
			}
			if (data.UEC_UEC57_Alam_Threats != null)
			{
				cmd.Parameters.AddWithValue("@Threats", data.UEC_UEC57_Alam_Threats);
			}
			else
			{
				cmd.Parameters.AddWithValue("@Threats", "");
			}
			cmd.Parameters.AddWithValue("@Probability", data.UEC_UEC57_Alam_Probability);
			cmd.Parameters.AddWithValue("@Consequence", data.UEC_UEC57_Alam_Consequence);


			con.Open();
			int i = cmd.ExecuteNonQuery();


			con.Close();
			if (i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}

		public bool AmalUpdateData(UEC_UEC57 data)
		{
			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("UPDATE dbo.Amal SET UnitName = @UnitName,UnitDescription = @UnitDescription ,BuiltAsDesign = @BuiltAsDesign ,IOW = @IOW    ,BasedLineInspection = @BasedLineInspection    ,CompliancewithCMM = @CompliancewithCMM   ,Inspection = @Inspection    ,NoTemporaryRepair = @NoTemporaryRepair    ,CompliancetoPerformanceStandard = @CompliancetoPerformanceStandard     ,FSR = @FSR , RiskLevel=@RiskLevel,CurrentStatus=@CurrentStatus,Threats=@Threats,Probability=@Probability,Consequence=@Consequence WHERE id=@id", con);
			UEC_UEC57_Alam_id = data.UEC_UEC57_Alam_id;
			cmd.Parameters.AddWithValue("@id", data.UEC_UEC57_Alam_id);

			cmd.Parameters.AddWithValue("@UnitName", data.UEC_UEC57_Alam_UnitName);
			cmd.Parameters.AddWithValue("@UnitDescription", data.UEC_UEC57_Alam_UnitDescription);
			cmd.Parameters.AddWithValue("@BuiltAsDesign", data.UEC_UEC57_Alam_BuiltAsDesign);
			cmd.Parameters.AddWithValue("@IOW", data.UEC_UEC57_Alam_IOW);
			cmd.Parameters.AddWithValue("@BasedLineInspection", data.UEC_UEC57_Alam_BasedLineInspection);
			cmd.Parameters.AddWithValue("@CompliancewithCMM", data.UEC_UEC57_Alam_CompliancewithCMM);
			cmd.Parameters.AddWithValue("@Inspection", data.UEC_UEC57_Alam_Inspection);
			cmd.Parameters.AddWithValue("@NoTemporaryRepair", data.UEC_UEC57_Alam_NoTemporaryRepair);
			cmd.Parameters.AddWithValue("@CompliancetoPerformanceStandard", data.UEC_UEC57_Alam_CompliancetoPerformanceStandard);
			cmd.Parameters.AddWithValue("@FSR", data.UEC_UEC57_Alam_FSR);

			cmd.Parameters.AddWithValue("@RiskLevel", data.UEC_UEC57_Alam_RiskLevel);
			if (data.UEC_UEC57_Alam_CurrentStatus != null)
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", data.UEC_UEC57_Alam_CurrentStatus);
			}
			else
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", "");
			}
			if (data.UEC_UEC57_Alam_Threats != null)
			{
				cmd.Parameters.AddWithValue("@Threats", data.UEC_UEC57_Alam_Threats);
			}
			else
			{
				cmd.Parameters.AddWithValue("@Threats", "");
			}
			cmd.Parameters.AddWithValue("@Probability", data.UEC_UEC57_Alam_Probability);
			cmd.Parameters.AddWithValue("@Consequence", data.UEC_UEC57_Alam_Consequence);


			con.Open();
			int i = cmd.ExecuteNonQuery();
			cmd.Dispose();

			con.Close();
			if (i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}
		public bool AmalDeleteData(int id)
		{
			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("delete from Amal where id=@id", con);

			cmd.Parameters.AddWithValue("@id", id);
			con.Open();
			int i = cmd.ExecuteNonQuery();
			cmd.Dispose();

			con.Close();
			if (i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}

		//CRUD FUNCTIONS FOR UEC_UEC57_Harweel
		public List<UEC_UEC57> HarweelgetData()
		{
			List<UEC_UEC57> dataList = new List<UEC_UEC57>();

			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("select * from dbo.Harweel order by id", con);

			con.Open();
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				UEC_UEC57 data = new UEC_UEC57();
				data.UEC_UEC57_Alam_id = Convert.ToInt32(dr.GetValue(0).ToString());
				data.UEC_UEC57_Alam_UnitName = dr.GetValue(1).ToString();
				data.UEC_UEC57_Alam_UnitDescription = dr.GetValue(2).ToString();

				data.UEC_UEC57_Alam_BuiltAsDesign = dr.GetValue(3).ToString();
				data.UEC_UEC57_Alam_IOW = dr.GetValue(4).ToString();
				data.UEC_UEC57_Alam_BasedLineInspection = dr.GetValue(5).ToString();
				data.UEC_UEC57_Alam_CompliancewithCMM = dr.GetValue(6).ToString();
				data.UEC_UEC57_Alam_Inspection = dr.GetValue(7).ToString();
				data.UEC_UEC57_Alam_NoTemporaryRepair = dr.GetValue(8).ToString();
				data.UEC_UEC57_Alam_CompliancetoPerformanceStandard = dr.GetValue(9).ToString();
				data.UEC_UEC57_Alam_FSR = dr.GetValue(10).ToString();
				data.UEC_UEC57_Alam_RiskLevel = dr.GetValue(11).ToString();
				data.UEC_UEC57_Alam_CurrentStatus = dr.GetValue(12).ToString();
				data.UEC_UEC57_Alam_Threats = dr.GetValue(13).ToString();
				data.UEC_UEC57_Alam_Probability = dr.GetValue(14).ToString();
				data.UEC_UEC57_Alam_Consequence = dr.GetValue(15).ToString();

				dataList.Add(data);
			}

			con.Close();


			return dataList;
		}
		public bool HarweelAddData(UEC_UEC57 data)
		{

			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Harweel(UnitName, UnitDescription, BuiltAsDesign, IOW, BasedLineInspection, CompliancewithCMM, Inspection, NoTemporaryRepair, CompliancetoPerformanceStandard, FSR,RiskLevel,CurrentStatus,Threats, Probability, Consequence)VALUES(@UnitName, @UnitDescription, @BuiltAsDesign, @IOW, @BasedLineInspection, @CompliancewithCMM,	 @Inspection, @NoTemporaryRepair, @CompliancetoPerformanceStandard, @FSR,@RiskLevel, @CurrentStatus, @Threats, @Probability, @Consequence)", con);
			cmd.Parameters.AddWithValue("@UnitName", data.UEC_UEC57_Alam_UnitName);
			cmd.Parameters.AddWithValue("@UnitDescription", data.UEC_UEC57_Alam_UnitDescription);
			cmd.Parameters.AddWithValue("@BuiltAsDesign", data.UEC_UEC57_Alam_BuiltAsDesign);
			cmd.Parameters.AddWithValue("@IOW", data.UEC_UEC57_Alam_IOW);
			cmd.Parameters.AddWithValue("@BasedLineInspection", data.UEC_UEC57_Alam_BasedLineInspection);
			cmd.Parameters.AddWithValue("@CompliancewithCMM", data.UEC_UEC57_Alam_CompliancewithCMM);
			cmd.Parameters.AddWithValue("@Inspection", data.UEC_UEC57_Alam_Inspection);
			cmd.Parameters.AddWithValue("@NoTemporaryRepair", data.UEC_UEC57_Alam_NoTemporaryRepair);
			cmd.Parameters.AddWithValue("@CompliancetoPerformanceStandard", data.UEC_UEC57_Alam_CompliancetoPerformanceStandard);
			cmd.Parameters.AddWithValue("@FSR", data.UEC_UEC57_Alam_FSR);

			cmd.Parameters.AddWithValue("@RiskLevel", data.UEC_UEC57_Alam_RiskLevel);
			if (data.UEC_UEC57_Alam_CurrentStatus != null)
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", data.UEC_UEC57_Alam_CurrentStatus);
			}
			else
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", "");
			}
			if (data.UEC_UEC57_Alam_Threats != null)
			{
				cmd.Parameters.AddWithValue("@Threats", data.UEC_UEC57_Alam_Threats);
			}
			else
			{
				cmd.Parameters.AddWithValue("@Threats", "");
			}
			cmd.Parameters.AddWithValue("@Probability", data.UEC_UEC57_Alam_Probability);
			cmd.Parameters.AddWithValue("@Consequence", data.UEC_UEC57_Alam_Consequence);


			con.Open();
			int i = cmd.ExecuteNonQuery();
			con.Close();
			if (i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}

		public bool HarweelUpdateData(UEC_UEC57 data)
		{
			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("UPDATE dbo.Harweel SET UnitName = @UnitName,UnitDescription = @UnitDescription ,BuiltAsDesign = @BuiltAsDesign ,IOW = @IOW    ,BasedLineInspection = @BasedLineInspection    ,CompliancewithCMM = @CompliancewithCMM   ,Inspection = @Inspection    ,NoTemporaryRepair = @NoTemporaryRepair    ,CompliancetoPerformanceStandard = @CompliancetoPerformanceStandard     ,FSR = @FSR ,RiskLevel=@RiskLevel, CurrentStatus=@CurrentStatus,Threats=@Threats,Probability=@Probability,Consequence=@Consequence WHERE id=@id", con);
			UEC_UEC57_Alam_id = data.UEC_UEC57_Alam_id;
			cmd.Parameters.AddWithValue("@id", data.UEC_UEC57_Alam_id);

			cmd.Parameters.AddWithValue("@UnitName", data.UEC_UEC57_Alam_UnitName);
			cmd.Parameters.AddWithValue("@UnitDescription", data.UEC_UEC57_Alam_UnitDescription);
			cmd.Parameters.AddWithValue("@BuiltAsDesign", data.UEC_UEC57_Alam_BuiltAsDesign);
			cmd.Parameters.AddWithValue("@IOW", data.UEC_UEC57_Alam_IOW);
			cmd.Parameters.AddWithValue("@BasedLineInspection", data.UEC_UEC57_Alam_BasedLineInspection);
			cmd.Parameters.AddWithValue("@CompliancewithCMM", data.UEC_UEC57_Alam_CompliancewithCMM);
			cmd.Parameters.AddWithValue("@Inspection", data.UEC_UEC57_Alam_Inspection);
			cmd.Parameters.AddWithValue("@NoTemporaryRepair", data.UEC_UEC57_Alam_NoTemporaryRepair);
			cmd.Parameters.AddWithValue("@CompliancetoPerformanceStandard", data.UEC_UEC57_Alam_CompliancetoPerformanceStandard);
			cmd.Parameters.AddWithValue("@FSR", data.UEC_UEC57_Alam_FSR);

			cmd.Parameters.AddWithValue("@RiskLevel", data.UEC_UEC57_Alam_RiskLevel);

			if (data.UEC_UEC57_Alam_CurrentStatus != null)
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", data.UEC_UEC57_Alam_CurrentStatus);
			}
			else
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", "");
			}
			if (data.UEC_UEC57_Alam_Threats != null)
			{
				cmd.Parameters.AddWithValue("@Threats", data.UEC_UEC57_Alam_Threats);
			}
			else
			{
				cmd.Parameters.AddWithValue("@Threats", "");
			}
			cmd.Parameters.AddWithValue("@Probability", data.UEC_UEC57_Alam_Probability);
			cmd.Parameters.AddWithValue("@Consequence", data.UEC_UEC57_Alam_Consequence);


			con.Open();
			int i = cmd.ExecuteNonQuery();
			cmd.Dispose();

			con.Close();
			if (i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}
		public bool HarweelDeleteData(int id)
		{
			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("delete from Harweel where id=@id", con);

			cmd.Parameters.AddWithValue("@id", id);
			con.Open();
			int i = cmd.ExecuteNonQuery();
			cmd.Dispose();

			con.Close();
			if (i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}
		//CRUD FUNCTIONS FOR UEC_UEC57_Birba
		public List<UEC_UEC57> BirbagetData()
		{
			List<UEC_UEC57> dataList = new List<UEC_UEC57>();

			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("select * from dbo.Birba order by id", con);

			con.Open();
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				UEC_UEC57 data = new UEC_UEC57();
				data.UEC_UEC57_Alam_id = Convert.ToInt32(dr.GetValue(0).ToString());
				data.UEC_UEC57_Alam_UnitName = dr.GetValue(1).ToString();
				data.UEC_UEC57_Alam_UnitDescription = dr.GetValue(2).ToString();

				data.UEC_UEC57_Alam_BuiltAsDesign = dr.GetValue(3).ToString();
				data.UEC_UEC57_Alam_IOW = dr.GetValue(4).ToString();
				data.UEC_UEC57_Alam_BasedLineInspection = dr.GetValue(5).ToString();
				data.UEC_UEC57_Alam_CompliancewithCMM = dr.GetValue(6).ToString();
				data.UEC_UEC57_Alam_Inspection = dr.GetValue(7).ToString();
				data.UEC_UEC57_Alam_NoTemporaryRepair = dr.GetValue(8).ToString();
				data.UEC_UEC57_Alam_CompliancetoPerformanceStandard = dr.GetValue(9).ToString();
				data.UEC_UEC57_Alam_FSR = dr.GetValue(10).ToString();
				data.UEC_UEC57_Alam_RiskLevel = dr.GetValue(11).ToString();
				data.UEC_UEC57_Alam_CurrentStatus = dr.GetValue(12).ToString();
				data.UEC_UEC57_Alam_Threats = dr.GetValue(13).ToString();
				data.UEC_UEC57_Alam_Probability = dr.GetValue(14).ToString();
				data.UEC_UEC57_Alam_Consequence = dr.GetValue(15).ToString();

				dataList.Add(data);
			}

			con.Close();


			return dataList;
		}
		public bool BirbaAddData(UEC_UEC57 data)
		{

			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Birba(UnitName, UnitDescription, BuiltAsDesign, IOW, BasedLineInspection, CompliancewithCMM, Inspection, NoTemporaryRepair, CompliancetoPerformanceStandard, FSR, RiskLevel, CurrentStatus,Threats, Probability, Consequence)VALUES(@UnitName, @UnitDescription, @BuiltAsDesign, @IOW, @BasedLineInspection, @CompliancewithCMM,	 @Inspection, @NoTemporaryRepair, @CompliancetoPerformanceStandard, @FSR,  @RiskLevel, @CurrentStatus, @Threats, @Probability, @Consequence)", con);
			cmd.Parameters.AddWithValue("@UnitName", data.UEC_UEC57_Alam_UnitName);
			cmd.Parameters.AddWithValue("@UnitDescription", data.UEC_UEC57_Alam_UnitDescription);
			cmd.Parameters.AddWithValue("@BuiltAsDesign", data.UEC_UEC57_Alam_BuiltAsDesign);
			cmd.Parameters.AddWithValue("@IOW", data.UEC_UEC57_Alam_IOW);
			cmd.Parameters.AddWithValue("@BasedLineInspection", data.UEC_UEC57_Alam_BasedLineInspection);
			cmd.Parameters.AddWithValue("@CompliancewithCMM", data.UEC_UEC57_Alam_CompliancewithCMM);
			cmd.Parameters.AddWithValue("@Inspection", data.UEC_UEC57_Alam_Inspection);
			cmd.Parameters.AddWithValue("@NoTemporaryRepair", data.UEC_UEC57_Alam_NoTemporaryRepair);
			cmd.Parameters.AddWithValue("@CompliancetoPerformanceStandard", data.UEC_UEC57_Alam_CompliancetoPerformanceStandard);
			cmd.Parameters.AddWithValue("@FSR", data.UEC_UEC57_Alam_FSR);

			cmd.Parameters.AddWithValue("@RiskLevel", data.UEC_UEC57_Alam_RiskLevel);
			if (data.UEC_UEC57_Alam_CurrentStatus != null)
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", data.UEC_UEC57_Alam_CurrentStatus);
			}
			else
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", "");
			}
			if (data.UEC_UEC57_Alam_Threats != null)
			{
				cmd.Parameters.AddWithValue("@Threats", data.UEC_UEC57_Alam_Threats);
			}
			else
			{
				cmd.Parameters.AddWithValue("@Threats", "");
			}
			cmd.Parameters.AddWithValue("@Probability", data.UEC_UEC57_Alam_Probability);
			cmd.Parameters.AddWithValue("@Consequence", data.UEC_UEC57_Alam_Consequence);



			con.Open();
			int i = cmd.ExecuteNonQuery();


			con.Close();
			if (i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}

		public bool BirbaUpdateData(UEC_UEC57 data)
		{
			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("UPDATE dbo.Birba SET UnitName = @UnitName,UnitDescription = @UnitDescription ,BuiltAsDesign = @BuiltAsDesign ,IOW = @IOW    ,BasedLineInspection = @BasedLineInspection    ,CompliancewithCMM = @CompliancewithCMM   ,Inspection = @Inspection    ,NoTemporaryRepair = @NoTemporaryRepair    ,CompliancetoPerformanceStandard = @CompliancetoPerformanceStandard     ,FSR = @FSR , RiskLevel=@RiskLevel,CurrentStatus=@CurrentStatus,Threats=@Threats,Probability=@Probability,Consequence=@Consequence WHERE id=@id", con);
			UEC_UEC57_Alam_id = data.UEC_UEC57_Alam_id;
			cmd.Parameters.AddWithValue("@id", data.UEC_UEC57_Alam_id);

			cmd.Parameters.AddWithValue("@UnitName", data.UEC_UEC57_Alam_UnitName);
			cmd.Parameters.AddWithValue("@UnitDescription", data.UEC_UEC57_Alam_UnitDescription);
			cmd.Parameters.AddWithValue("@BuiltAsDesign", data.UEC_UEC57_Alam_BuiltAsDesign);
			cmd.Parameters.AddWithValue("@IOW", data.UEC_UEC57_Alam_IOW);
			cmd.Parameters.AddWithValue("@BasedLineInspection", data.UEC_UEC57_Alam_BasedLineInspection);
			cmd.Parameters.AddWithValue("@CompliancewithCMM", data.UEC_UEC57_Alam_CompliancewithCMM);
			cmd.Parameters.AddWithValue("@Inspection", data.UEC_UEC57_Alam_Inspection);
			cmd.Parameters.AddWithValue("@NoTemporaryRepair", data.UEC_UEC57_Alam_NoTemporaryRepair);
			cmd.Parameters.AddWithValue("@CompliancetoPerformanceStandard", data.UEC_UEC57_Alam_CompliancetoPerformanceStandard);
			cmd.Parameters.AddWithValue("@FSR", data.UEC_UEC57_Alam_FSR);

			cmd.Parameters.AddWithValue("@RiskLevel", data.UEC_UEC57_Alam_RiskLevel);
			if (data.UEC_UEC57_Alam_CurrentStatus != null)
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", data.UEC_UEC57_Alam_CurrentStatus);
			}
			else
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", "");
			}
			if (data.UEC_UEC57_Alam_Threats != null)
			{
				cmd.Parameters.AddWithValue("@Threats", data.UEC_UEC57_Alam_Threats);
			}
			else
			{
				cmd.Parameters.AddWithValue("@Threats", "");
			}
			cmd.Parameters.AddWithValue("@Probability", data.UEC_UEC57_Alam_Probability);
			cmd.Parameters.AddWithValue("@Consequence", data.UEC_UEC57_Alam_Consequence);


			con.Open();
			int i = cmd.ExecuteNonQuery();
			cmd.Dispose();

			con.Close();
			if (i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}
		public bool BirbaDeleteData(int id)
		{
			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("delete from Birba where id=@id", con);

			cmd.Parameters.AddWithValue("@id", id);
			con.Open();
			int i = cmd.ExecuteNonQuery();
			cmd.Dispose();

			con.Close();
			if (i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}
		//CRUD FUNCTIONS FOR UEC_UEC57_Alnoor
		public List<UEC_UEC57> AlnoorgetData()
		{
			List<UEC_UEC57> dataList = new List<UEC_UEC57>();

			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("select * from dbo.Alnoor order by id", con);

			con.Open();
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				UEC_UEC57 data = new UEC_UEC57();
				data.UEC_UEC57_Alam_id = Convert.ToInt32(dr.GetValue(0).ToString());
				data.UEC_UEC57_Alam_UnitName = dr.GetValue(1).ToString();
				data.UEC_UEC57_Alam_UnitDescription = dr.GetValue(2).ToString();

				data.UEC_UEC57_Alam_BuiltAsDesign = dr.GetValue(3).ToString();
				data.UEC_UEC57_Alam_IOW = dr.GetValue(4).ToString();
				data.UEC_UEC57_Alam_BasedLineInspection = dr.GetValue(5).ToString();
				data.UEC_UEC57_Alam_CompliancewithCMM = dr.GetValue(6).ToString();
				data.UEC_UEC57_Alam_Inspection = dr.GetValue(7).ToString();
				data.UEC_UEC57_Alam_NoTemporaryRepair = dr.GetValue(8).ToString();
				data.UEC_UEC57_Alam_CompliancetoPerformanceStandard = dr.GetValue(9).ToString();
				data.UEC_UEC57_Alam_FSR = dr.GetValue(10).ToString();
				data.UEC_UEC57_Alam_RiskLevel = dr.GetValue(11).ToString();
				data.UEC_UEC57_Alam_CurrentStatus = dr.GetValue(12).ToString();
				data.UEC_UEC57_Alam_Threats = dr.GetValue(13).ToString();
				data.UEC_UEC57_Alam_Probability = dr.GetValue(14).ToString();
				data.UEC_UEC57_Alam_Consequence = dr.GetValue(15).ToString();

				dataList.Add(data);
			}

			con.Close();


			return dataList;
		}
		public bool AlnoorAddData(UEC_UEC57 data)
		{

			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Alnoor(UnitName, UnitDescription, BuiltAsDesign, IOW, BasedLineInspection, CompliancewithCMM, Inspection, NoTemporaryRepair, CompliancetoPerformanceStandard, FSR, RiskLevel, CurrentStatus,Threats, Probability, Consequence)VALUES(@UnitName, @UnitDescription, @BuiltAsDesign, @IOW, @BasedLineInspection, @CompliancewithCMM,	 @Inspection, @NoTemporaryRepair, @CompliancetoPerformanceStandard, @FSR,  @RiskLevel, @CurrentStatus, @Threats, @Probability, @Consequence)", con);
			cmd.Parameters.AddWithValue("@UnitName", data.UEC_UEC57_Alam_UnitName);
			cmd.Parameters.AddWithValue("@UnitDescription", data.UEC_UEC57_Alam_UnitDescription);
			cmd.Parameters.AddWithValue("@BuiltAsDesign", data.UEC_UEC57_Alam_BuiltAsDesign);
			cmd.Parameters.AddWithValue("@IOW", data.UEC_UEC57_Alam_IOW);
			cmd.Parameters.AddWithValue("@BasedLineInspection", data.UEC_UEC57_Alam_BasedLineInspection);
			cmd.Parameters.AddWithValue("@CompliancewithCMM", data.UEC_UEC57_Alam_CompliancewithCMM);
			cmd.Parameters.AddWithValue("@Inspection", data.UEC_UEC57_Alam_Inspection);
			cmd.Parameters.AddWithValue("@NoTemporaryRepair", data.UEC_UEC57_Alam_NoTemporaryRepair);
			cmd.Parameters.AddWithValue("@CompliancetoPerformanceStandard", data.UEC_UEC57_Alam_CompliancetoPerformanceStandard);
			cmd.Parameters.AddWithValue("@FSR", data.UEC_UEC57_Alam_FSR);

			cmd.Parameters.AddWithValue("@RiskLevel", data.UEC_UEC57_Alam_RiskLevel);
			if (data.UEC_UEC57_Alam_CurrentStatus != null)
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", data.UEC_UEC57_Alam_CurrentStatus);
			}
			else
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", "");
			}
			if (data.UEC_UEC57_Alam_Threats != null)
			{
				cmd.Parameters.AddWithValue("@Threats", data.UEC_UEC57_Alam_Threats);
			}
			else
			{
				cmd.Parameters.AddWithValue("@Threats", "");
			}
			cmd.Parameters.AddWithValue("@Probability", data.UEC_UEC57_Alam_Probability);
			cmd.Parameters.AddWithValue("@Consequence", data.UEC_UEC57_Alam_Consequence);



			con.Open();
			int i = cmd.ExecuteNonQuery();



			con.Close();
			if (i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}

		public bool AlnoorUpdateData(UEC_UEC57 data)
		{
			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("UPDATE dbo.Alnoor SET UnitName = @UnitName,UnitDescription = @UnitDescription ,BuiltAsDesign = @BuiltAsDesign ,IOW = @IOW    ,BasedLineInspection = @BasedLineInspection    ,CompliancewithCMM = @CompliancewithCMM   ,Inspection = @Inspection    ,NoTemporaryRepair = @NoTemporaryRepair    ,CompliancetoPerformanceStandard = @CompliancetoPerformanceStandard     ,FSR = @FSR , RiskLevel=@RiskLevel,CurrentStatus=@CurrentStatus,Threats=@Threats,Probability=@Probability,Consequence=@Consequence WHERE id=@id", con);
			UEC_UEC57_Alam_id = data.UEC_UEC57_Alam_id;
			cmd.Parameters.AddWithValue("@id", data.UEC_UEC57_Alam_id);

			cmd.Parameters.AddWithValue("@UnitName", data.UEC_UEC57_Alam_UnitName);
			cmd.Parameters.AddWithValue("@UnitDescription", data.UEC_UEC57_Alam_UnitDescription);
			cmd.Parameters.AddWithValue("@BuiltAsDesign", data.UEC_UEC57_Alam_BuiltAsDesign);
			cmd.Parameters.AddWithValue("@IOW", data.UEC_UEC57_Alam_IOW);
			cmd.Parameters.AddWithValue("@BasedLineInspection", data.UEC_UEC57_Alam_BasedLineInspection);
			cmd.Parameters.AddWithValue("@CompliancewithCMM", data.UEC_UEC57_Alam_CompliancewithCMM);
			cmd.Parameters.AddWithValue("@Inspection", data.UEC_UEC57_Alam_Inspection);
			cmd.Parameters.AddWithValue("@NoTemporaryRepair", data.UEC_UEC57_Alam_NoTemporaryRepair);
			cmd.Parameters.AddWithValue("@CompliancetoPerformanceStandard", data.UEC_UEC57_Alam_CompliancetoPerformanceStandard);
			cmd.Parameters.AddWithValue("@FSR", data.UEC_UEC57_Alam_FSR);

			cmd.Parameters.AddWithValue("@RiskLevel", data.UEC_UEC57_Alam_RiskLevel);
			if (data.UEC_UEC57_Alam_CurrentStatus != null)
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", data.UEC_UEC57_Alam_CurrentStatus);
			}
			else
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", "");
			}
			if (data.UEC_UEC57_Alam_Threats != null)
			{
				cmd.Parameters.AddWithValue("@Threats", data.UEC_UEC57_Alam_Threats);
			}
			else
			{
				cmd.Parameters.AddWithValue("@Threats", "");
			}
			cmd.Parameters.AddWithValue("@Probability", data.UEC_UEC57_Alam_Probability);
			cmd.Parameters.AddWithValue("@Consequence", data.UEC_UEC57_Alam_Consequence);


			con.Open();
			int i = cmd.ExecuteNonQuery();
			cmd.Dispose();

			con.Close();
			if (i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}
		public bool AlnoorDeleteData(int id)
		{
			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("delete from Alnoor where id=@id", con);

			cmd.Parameters.AddWithValue("@id", id);
			con.Open();
			int i = cmd.ExecuteNonQuery();
			cmd.Dispose();

			con.Close();
			if (i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}
		//CRUD FUNCTIONS FOR UEC_UEC57_RHIP
		public List<UEC_UEC57> RHIPgetData()
		{
			List<UEC_UEC57> dataList = new List<UEC_UEC57>();

			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("select * from dbo.RHIP order by id", con);

			con.Open();
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				UEC_UEC57 data = new UEC_UEC57();
				data.UEC_UEC57_Alam_id = Convert.ToInt32(dr.GetValue(0).ToString());
				data.UEC_UEC57_Alam_UnitName = dr.GetValue(1).ToString();
				data.UEC_UEC57_Alam_UnitDescription = dr.GetValue(2).ToString();

				data.UEC_UEC57_Alam_BuiltAsDesign = dr.GetValue(3).ToString();
				data.UEC_UEC57_Alam_IOW = dr.GetValue(4).ToString();
				data.UEC_UEC57_Alam_BasedLineInspection = dr.GetValue(5).ToString();
				data.UEC_UEC57_Alam_CompliancewithCMM = dr.GetValue(6).ToString();
				data.UEC_UEC57_Alam_Inspection = dr.GetValue(7).ToString();
				data.UEC_UEC57_Alam_NoTemporaryRepair = dr.GetValue(8).ToString();
				data.UEC_UEC57_Alam_CompliancetoPerformanceStandard = dr.GetValue(9).ToString();
				data.UEC_UEC57_Alam_FSR = dr.GetValue(10).ToString();
				data.UEC_UEC57_Alam_RiskLevel = dr.GetValue(11).ToString();
				data.UEC_UEC57_Alam_CurrentStatus = dr.GetValue(12).ToString();
				data.UEC_UEC57_Alam_Threats = dr.GetValue(13).ToString();
				data.UEC_UEC57_Alam_Probability = dr.GetValue(14).ToString();
				data.UEC_UEC57_Alam_Consequence = dr.GetValue(15).ToString();
				dataList.Add(data);
			}

			con.Close();


			return dataList;
		}
		public bool RHIPAddData(UEC_UEC57 data)
		{

			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("INSERT INTO dbo.RHIP(UnitName, UnitDescription, BuiltAsDesign, IOW, BasedLineInspection, CompliancewithCMM, Inspection, NoTemporaryRepair, CompliancetoPerformanceStandard, FSR, RiskLevel, CurrentStatus,Threats, Probability, Consequence)VALUES(@UnitName, @UnitDescription, @BuiltAsDesign, @IOW, @BasedLineInspection, @CompliancewithCMM,	 @Inspection, @NoTemporaryRepair, @CompliancetoPerformanceStandard, @FSR,  @RiskLevel, @CurrentStatus, @Threats, @Probability, @Consequence)", con);
			cmd.Parameters.AddWithValue("@UnitName", data.UEC_UEC57_Alam_UnitName);
			cmd.Parameters.AddWithValue("@UnitDescription", data.UEC_UEC57_Alam_UnitDescription);
			cmd.Parameters.AddWithValue("@BuiltAsDesign", data.UEC_UEC57_Alam_BuiltAsDesign);
			cmd.Parameters.AddWithValue("@IOW", data.UEC_UEC57_Alam_IOW);
			cmd.Parameters.AddWithValue("@BasedLineInspection", data.UEC_UEC57_Alam_BasedLineInspection);
			cmd.Parameters.AddWithValue("@CompliancewithCMM", data.UEC_UEC57_Alam_CompliancewithCMM);
			cmd.Parameters.AddWithValue("@Inspection", data.UEC_UEC57_Alam_Inspection);
			cmd.Parameters.AddWithValue("@NoTemporaryRepair", data.UEC_UEC57_Alam_NoTemporaryRepair);
			cmd.Parameters.AddWithValue("@CompliancetoPerformanceStandard", data.UEC_UEC57_Alam_CompliancetoPerformanceStandard);
			cmd.Parameters.AddWithValue("@FSR", data.UEC_UEC57_Alam_FSR);

			cmd.Parameters.AddWithValue("@RiskLevel", data.UEC_UEC57_Alam_RiskLevel);
			if (data.UEC_UEC57_Alam_CurrentStatus != null)
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", data.UEC_UEC57_Alam_CurrentStatus);
			}
			else
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", "");
			}
			if (data.UEC_UEC57_Alam_Threats != null)
			{
				cmd.Parameters.AddWithValue("@Threats", data.UEC_UEC57_Alam_Threats);
			}
			else
			{
				cmd.Parameters.AddWithValue("@Threats", "");
			}
			cmd.Parameters.AddWithValue("@Probability", data.UEC_UEC57_Alam_Probability);
			cmd.Parameters.AddWithValue("@Consequence", data.UEC_UEC57_Alam_Consequence);

			con.Open();
			int i = cmd.ExecuteNonQuery();


			con.Close();
			if (i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}

		public bool RHIPUpdateData(UEC_UEC57 data)
		{
			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("UPDATE dbo.RHIP SET UnitName = @UnitName,UnitDescription = @UnitDescription ,BuiltAsDesign = @BuiltAsDesign ,IOW = @IOW    ,BasedLineInspection = @BasedLineInspection    ,CompliancewithCMM = @CompliancewithCMM   ,Inspection = @Inspection    ,NoTemporaryRepair = @NoTemporaryRepair    ,CompliancetoPerformanceStandard = @CompliancetoPerformanceStandard     ,FSR = @FSR , RiskLevel=@RiskLevel,CurrentStatus=@CurrentStatus,Threats=@Threats,Probability=@Probability,Consequence=@Consequence WHERE id=@id", con);
			UEC_UEC57_Alam_id = data.UEC_UEC57_Alam_id;
			cmd.Parameters.AddWithValue("@id", data.UEC_UEC57_Alam_id);

			cmd.Parameters.AddWithValue("@UnitName", data.UEC_UEC57_Alam_UnitName);
			cmd.Parameters.AddWithValue("@UnitDescription", data.UEC_UEC57_Alam_UnitDescription);
			cmd.Parameters.AddWithValue("@BuiltAsDesign", data.UEC_UEC57_Alam_BuiltAsDesign);
			cmd.Parameters.AddWithValue("@IOW", data.UEC_UEC57_Alam_IOW);
			cmd.Parameters.AddWithValue("@BasedLineInspection", data.UEC_UEC57_Alam_BasedLineInspection);
			cmd.Parameters.AddWithValue("@CompliancewithCMM", data.UEC_UEC57_Alam_CompliancewithCMM);
			cmd.Parameters.AddWithValue("@Inspection", data.UEC_UEC57_Alam_Inspection);
			cmd.Parameters.AddWithValue("@NoTemporaryRepair", data.UEC_UEC57_Alam_NoTemporaryRepair);
			cmd.Parameters.AddWithValue("@CompliancetoPerformanceStandard", data.UEC_UEC57_Alam_CompliancetoPerformanceStandard);
			cmd.Parameters.AddWithValue("@FSR", data.UEC_UEC57_Alam_FSR);

			cmd.Parameters.AddWithValue("@RiskLevel", data.UEC_UEC57_Alam_RiskLevel);
			if (data.UEC_UEC57_Alam_CurrentStatus != null)
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", data.UEC_UEC57_Alam_CurrentStatus);
			}
			else
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", "");
			}
			if (data.UEC_UEC57_Alam_Threats != null)
			{
				cmd.Parameters.AddWithValue("@Threats", data.UEC_UEC57_Alam_Threats);
			}
			else
			{
				cmd.Parameters.AddWithValue("@Threats", "");
			}
			cmd.Parameters.AddWithValue("@Probability", data.UEC_UEC57_Alam_Probability);
			cmd.Parameters.AddWithValue("@Consequence", data.UEC_UEC57_Alam_Consequence);


			con.Open();
			int i = cmd.ExecuteNonQuery();
			cmd.Dispose();
			con.Close();
			if (i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}
		public bool RHIPDeleteData(int id)
		{
			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("delete from RHIP where id=@id", con);

			cmd.Parameters.AddWithValue("@id", id);
			con.Open();
			int i = cmd.ExecuteNonQuery();
			cmd.Dispose();

			con.Close();
			if (i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}
		//CRUD FUNCTIONS FOR UEC_UEC57_YKP
		public List<UEC_UEC57> YKPgetData()
		{
			List<UEC_UEC57> dataList = new List<UEC_UEC57>();

			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("select * from dbo.YKP order by id", con);

			con.Open();
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				UEC_UEC57 data = new UEC_UEC57();
				data.UEC_UEC57_Alam_id = Convert.ToInt32(dr.GetValue(0).ToString());
				data.UEC_UEC57_Alam_UnitName = dr.GetValue(1).ToString();
				data.UEC_UEC57_Alam_UnitDescription = dr.GetValue(2).ToString();

				data.UEC_UEC57_Alam_BuiltAsDesign = dr.GetValue(3).ToString();
				data.UEC_UEC57_Alam_IOW = dr.GetValue(4).ToString();
				data.UEC_UEC57_Alam_BasedLineInspection = dr.GetValue(5).ToString();
				data.UEC_UEC57_Alam_CompliancewithCMM = dr.GetValue(6).ToString();
				data.UEC_UEC57_Alam_Inspection = dr.GetValue(7).ToString();
				data.UEC_UEC57_Alam_NoTemporaryRepair = dr.GetValue(8).ToString();
				data.UEC_UEC57_Alam_CompliancetoPerformanceStandard = dr.GetValue(9).ToString();
				data.UEC_UEC57_Alam_FSR = dr.GetValue(10).ToString();
				data.UEC_UEC57_Alam_RiskLevel = dr.GetValue(11).ToString();
				data.UEC_UEC57_Alam_CurrentStatus = dr.GetValue(12).ToString();
				data.UEC_UEC57_Alam_Threats = dr.GetValue(13).ToString();
				data.UEC_UEC57_Alam_Probability = dr.GetValue(14).ToString();
				data.UEC_UEC57_Alam_Consequence = dr.GetValue(15).ToString();
				dataList.Add(data);
			}

			con.Close();


			return dataList;
		}
		public bool YKPAddData(UEC_UEC57 data)
		{

			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("INSERT INTO dbo.YKP(UnitName, UnitDescription, BuiltAsDesign, IOW, BasedLineInspection, CompliancewithCMM, Inspection, NoTemporaryRepair, CompliancetoPerformanceStandard, FSR, RiskLevel, CurrentStatus,Threats, Probability, Consequence)VALUES(@UnitName, @UnitDescription, @BuiltAsDesign, @IOW, @BasedLineInspection, @CompliancewithCMM,	 @Inspection, @NoTemporaryRepair, @CompliancetoPerformanceStandard, @FSR,  @RiskLevel, @CurrentStatus, @Threats, @Probability, @Consequence)", con);
			cmd.Parameters.AddWithValue("@UnitName", data.UEC_UEC57_Alam_UnitName);
			cmd.Parameters.AddWithValue("@UnitDescription", data.UEC_UEC57_Alam_UnitDescription);
			cmd.Parameters.AddWithValue("@BuiltAsDesign", data.UEC_UEC57_Alam_BuiltAsDesign);
			cmd.Parameters.AddWithValue("@IOW", data.UEC_UEC57_Alam_IOW);
			cmd.Parameters.AddWithValue("@BasedLineInspection", data.UEC_UEC57_Alam_BasedLineInspection);
			cmd.Parameters.AddWithValue("@CompliancewithCMM", data.UEC_UEC57_Alam_CompliancewithCMM);
			cmd.Parameters.AddWithValue("@Inspection", data.UEC_UEC57_Alam_Inspection);
			cmd.Parameters.AddWithValue("@NoTemporaryRepair", data.UEC_UEC57_Alam_NoTemporaryRepair);
			cmd.Parameters.AddWithValue("@CompliancetoPerformanceStandard", data.UEC_UEC57_Alam_CompliancetoPerformanceStandard);
			cmd.Parameters.AddWithValue("@FSR", data.UEC_UEC57_Alam_FSR);

			cmd.Parameters.AddWithValue("@RiskLevel", data.UEC_UEC57_Alam_RiskLevel);
			if (data.UEC_UEC57_Alam_CurrentStatus != null)
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", data.UEC_UEC57_Alam_CurrentStatus);
			}
			else
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", "");
			}
			if (data.UEC_UEC57_Alam_Threats != null)
			{
				cmd.Parameters.AddWithValue("@Threats", data.UEC_UEC57_Alam_Threats);
			}
			else
			{
				cmd.Parameters.AddWithValue("@Threats", "");
			}
			cmd.Parameters.AddWithValue("@Probability", data.UEC_UEC57_Alam_Probability);
			cmd.Parameters.AddWithValue("@Consequence", data.UEC_UEC57_Alam_Consequence);

			con.Open();
			int i = cmd.ExecuteNonQuery();


			con.Close();
			if (i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}

		public bool YKPUpdateData(UEC_UEC57 data)
		{
			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("UPDATE dbo.YKP SET UnitName = @UnitName,UnitDescription = @UnitDescription ,BuiltAsDesign = @BuiltAsDesign ,IOW = @IOW    ,BasedLineInspection = @BasedLineInspection    ,CompliancewithCMM = @CompliancewithCMM   ,Inspection = @Inspection    ,NoTemporaryRepair = @NoTemporaryRepair    ,CompliancetoPerformanceStandard = @CompliancetoPerformanceStandard     ,FSR = @FSR , RiskLevel=@RiskLevel,CurrentStatus=@CurrentStatus,Threats=@Threats,Probability=@Probability,Consequence=@Consequence WHERE id=@id", con);
			UEC_UEC57_Alam_id = data.UEC_UEC57_Alam_id;
			cmd.Parameters.AddWithValue("@id", data.UEC_UEC57_Alam_id);

			cmd.Parameters.AddWithValue("@UnitName", data.UEC_UEC57_Alam_UnitName);
			cmd.Parameters.AddWithValue("@UnitDescription", data.UEC_UEC57_Alam_UnitDescription);
			cmd.Parameters.AddWithValue("@BuiltAsDesign", data.UEC_UEC57_Alam_BuiltAsDesign);
			cmd.Parameters.AddWithValue("@IOW", data.UEC_UEC57_Alam_IOW);
			cmd.Parameters.AddWithValue("@BasedLineInspection", data.UEC_UEC57_Alam_BasedLineInspection);
			cmd.Parameters.AddWithValue("@CompliancewithCMM", data.UEC_UEC57_Alam_CompliancewithCMM);
			cmd.Parameters.AddWithValue("@Inspection", data.UEC_UEC57_Alam_Inspection);
			cmd.Parameters.AddWithValue("@NoTemporaryRepair", data.UEC_UEC57_Alam_NoTemporaryRepair);
			cmd.Parameters.AddWithValue("@CompliancetoPerformanceStandard", data.UEC_UEC57_Alam_CompliancetoPerformanceStandard);
			cmd.Parameters.AddWithValue("@FSR", data.UEC_UEC57_Alam_FSR);

			cmd.Parameters.AddWithValue("@RiskLevel", data.UEC_UEC57_Alam_RiskLevel);
			if (data.UEC_UEC57_Alam_CurrentStatus != null)
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", data.UEC_UEC57_Alam_CurrentStatus);
			}
			else
			{
				cmd.Parameters.AddWithValue("@CurrentStatus", "");
			}
			if (data.UEC_UEC57_Alam_Threats != null)
			{
				cmd.Parameters.AddWithValue("@Threats", data.UEC_UEC57_Alam_Threats);
			}
			else
			{
				cmd.Parameters.AddWithValue("@Threats", "");
			}
			cmd.Parameters.AddWithValue("@Probability", data.UEC_UEC57_Alam_Probability);
			cmd.Parameters.AddWithValue("@Consequence", data.UEC_UEC57_Alam_Consequence);


			con.Open();
			int i = cmd.ExecuteNonQuery();
			cmd.Dispose();

			con.Close();
			if (i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}
		public bool YKPDeleteData(int id)
		{
			SqlConnection con = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("delete from YKP where id=@id", con);

			cmd.Parameters.AddWithValue("@id", id);
			con.Open();
			int i = cmd.ExecuteNonQuery();
			cmd.Dispose();

			con.Close();
			if (i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}
	}
}