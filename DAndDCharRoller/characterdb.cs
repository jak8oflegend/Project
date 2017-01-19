using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAndDCharRoller
{
    class characterdb
    {
        public static bool Addcharacter(character character)
        {
            SqlConnection con =
                DBHelper.GetConnection();

            SqlCommand addcharacterCommand =
                new SqlCommand();
            addcharacterCommand.Connection = con;
            addcharacterCommand.CommandText =
                @"INSERT INTO CharDB
	                ( name,
             Strength,
 Dexterity,
 Constitution,
 Intelligence,
 Wisdom,
 Charisma,
             Strengthbonus,
 Dexteritybonus,
 Constitutionbonus,
 Intelligencebonus,
 Wisdombonus,
 Charismabonus)
VALUES
	                (@name,
@Strength,
@Dexterity,
@Constitution,
@Intelligence,
@Wisdom,
@Charisma,
@Strengthbonus,
@Dexteritybonus,
@Constitutionbonus,
@Intelligencebonus,
@Wisdombonus,
@Charismabonus)";

            addcharacterCommand.Parameters
                .AddWithValue("@Name", character.name);
            addcharacterCommand.Parameters
    .AddWithValue("@Strength", character.Strength);
            addcharacterCommand.Parameters
.AddWithValue("@Dexterity", character.Dexterity);
            addcharacterCommand.Parameters
.AddWithValue("@Constitution", character.Constitution);
            addcharacterCommand.Parameters
.AddWithValue("@Intelligence", character.Intelligence);
            addcharacterCommand.Parameters
.AddWithValue("@Wisdom", character.Wisdom);
            addcharacterCommand.Parameters
.AddWithValue("@Charisma", character.Charisma);
            addcharacterCommand.Parameters
.AddWithValue("@Strengthbonus", character.Strengthbonus);
            addcharacterCommand.Parameters
.AddWithValue("@Dexteritybonus", character.Dexteritybonus);
            addcharacterCommand.Parameters
.AddWithValue("@Constitutionbonus", character.Constitutionbonus);
            addcharacterCommand.Parameters
.AddWithValue("@Intelligencebonus", character.Intelligencebonus);
            addcharacterCommand.Parameters
.AddWithValue("@Wisdombonus", character.Wisdombonus);
            addcharacterCommand.Parameters
.AddWithValue("@Charismabonus", character.Charismabonus);



            try
            {
                con.Open();

                int rows =
                    addcharacterCommand.ExecuteNonQuery();

                if (rows == 1)
                    return true;

                return false;
            }
            finally
            {
                con.Dispose();
            }
        }
    }
}
