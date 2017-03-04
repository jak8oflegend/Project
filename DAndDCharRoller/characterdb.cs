using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAndDCharRoller
{
    /// <summary>
    /// accesses the database and stores to database
    /// todo: add alighnment
    /// todo: add template once it is implemented
    /// todo: add in the skills once form3 is implemented and skills are implemented
    /// </summary>
    class characterdb
    {
        public static bool Addcharacter(character character)
        {
            ///adds character to db
            SqlConnection con =
                DBHelper.GetConnection();

            SqlCommand addcharacterCommand =
                new SqlCommand();
            addcharacterCommand.Connection = con;
            addcharacterCommand.CommandText =
                @"INSERT INTO Character
	                ( name,
alighnment,
 jobclass,
 race,

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
 Charismabonus,
				appraise ,
              balance ,
              bluff ,
              climb ,
              concentrate ,
              craft1 ,
              craft2 ,
              craft3 ,
              deciferScript ,
              diplomacy ,
              disableDevice ,
              disguise ,
              escapeArtist ,
              forgery ,
              gatherInformation ,
              handleanimal ,
              heal ,
              intimidate ,
              jump ,
              arcana ,
              Architecture ,
              dungeonereing ,
              geography ,
              history ,
              local ,
              nature ,
              noble ,
              religion ,
              planes ,
              listen ,
              moveSilently ,
              openLock ,
              preform1 ,
              preform2 ,
              preform3 ,
              preform4 ,
              preform5 ,
              profession ,
              ride ,
              search ,
              senseMotive ,
              sleightOfHand ,
              speakLanguage ,
              spellcraft ,
              spot ,
              survival ,
              swim ,
              tumble ,
              useMagicDevice ,
              useRope,
              autohypnosis ,
              psionics ,
              psicraft ,
              usePsi

)
VALUES
	                (@name,
@alighnment,
@jobclass,
@race,
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
@Charismabonus,
				@appraise , @balance , @bluff , @climb , @concentrate , @craft1 , @craft2 , @craft3 , @deciferScript , @diplomacy , @disableDevice , @disguise , @escapeArtist , @forgery , @gatherInformation , @handleanimal , @heal , @intimidate , 
				@jump , @arcana , @Architecture , @dungeonereing , @geography , @history , @local , @nature , @noble , @religion , @planes , @listen , @moveSilently , @openLock , @preform1 , @preform2 , @preform3 , @preform4 , @preform5 , 
				@profession , @ride , @search , @senseMotive , @sleightOfHand , @speakLanguage , @spellcraft , @spot , @survival , @swim , @tumble , @useMagicDevice , @useRope, @autohypnosis , @psionics , @psicraft , @usePsi)";

            addcharacterCommand.Parameters.AddWithValue("@Name", character.name);
            addcharacterCommand.Parameters
                .AddWithValue("@alighnment", character.alighnment);
            addcharacterCommand.Parameters
    .AddWithValue("@race", character.race);
            addcharacterCommand.Parameters
    .AddWithValue("@jobclass", character.jobclass);
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
            addcharacterCommand.Parameters.AddWithValue("@appraise", character.skills[0].value);
            addcharacterCommand.Parameters.AddWithValue("@balance", character.skills[1].value);
            addcharacterCommand.Parameters.AddWithValue("@bluff", character.skills[2].value);
            addcharacterCommand.Parameters.AddWithValue("@climb", character.skills[3].value);
            addcharacterCommand.Parameters.AddWithValue("@concentrate", character.skills[4].value);
            addcharacterCommand.Parameters.AddWithValue("@craft1", character.skills[5].value);
            addcharacterCommand.Parameters.AddWithValue("@craft2", character.skills[6].value);
            addcharacterCommand.Parameters.AddWithValue("@craft3", character.skills[7].value);
            addcharacterCommand.Parameters.AddWithValue("@deciferScript", character.skills[8].value);
            addcharacterCommand.Parameters.AddWithValue("@diplomacy", character.skills[9].value);
            addcharacterCommand.Parameters.AddWithValue("@disableDevice", character.skills[10].value);
            addcharacterCommand.Parameters.AddWithValue("@disguise", character.skills[11].value);
            addcharacterCommand.Parameters.AddWithValue("@escapeArtist", character.skills[12].value);
            addcharacterCommand.Parameters.AddWithValue("@forgery", character.skills[13].value);
            addcharacterCommand.Parameters.AddWithValue("@gatherInformation", character.skills[14].value);
            addcharacterCommand.Parameters.AddWithValue("@handleanimal", character.skills[15].value);
            addcharacterCommand.Parameters.AddWithValue("@heal", character.skills[16].value);
            addcharacterCommand.Parameters.AddWithValue("@intimidate", character.skills[17].value);
            addcharacterCommand.Parameters.AddWithValue("@jump", character.skills[18].value);
            addcharacterCommand.Parameters.AddWithValue("@arcana", character.skills[19].value);
            addcharacterCommand.Parameters.AddWithValue("@Architecture", character.skills[20].value);
            addcharacterCommand.Parameters.AddWithValue("@dungeonereing", character.skills[21].value);
            addcharacterCommand.Parameters.AddWithValue("@geography", character.skills[22].value);
            addcharacterCommand.Parameters.AddWithValue("@history", character.skills[23].value);
            addcharacterCommand.Parameters.AddWithValue("@local", character.skills[24].value);
            addcharacterCommand.Parameters.AddWithValue("@nature", character.skills[25].value);
            addcharacterCommand.Parameters.AddWithValue("@noble", character.skills[26].value);
            addcharacterCommand.Parameters.AddWithValue("@religion", character.skills[27].value);
            addcharacterCommand.Parameters.AddWithValue("@planes", character.skills[28].value);
            addcharacterCommand.Parameters.AddWithValue("@listen", character.skills[29].value);
            addcharacterCommand.Parameters.AddWithValue("@moveSilently", character.skills[30].value);
            addcharacterCommand.Parameters.AddWithValue("@openLock", character.skills[31].value);
            addcharacterCommand.Parameters.AddWithValue("@preform1", character.skills[32].value);
            addcharacterCommand.Parameters.AddWithValue("@preform2", character.skills[33].value);
            addcharacterCommand.Parameters.AddWithValue("@preform3", character.skills[34].value);
            addcharacterCommand.Parameters.AddWithValue("@preform4", character.skills[35].value);
            addcharacterCommand.Parameters.AddWithValue("@preform5", character.skills[36].value);
            addcharacterCommand.Parameters.AddWithValue("@profession", character.skills[37].value);
            addcharacterCommand.Parameters.AddWithValue("@ride", character.skills[38].value);
            addcharacterCommand.Parameters.AddWithValue("@search", character.skills[39].value);
            addcharacterCommand.Parameters.AddWithValue("@senseMotive", character.skills[40].value);
            addcharacterCommand.Parameters.AddWithValue("@sleightOfHand", character.skills[41].value);
            addcharacterCommand.Parameters.AddWithValue("@speakLanguage", character.skills[42].value);
            addcharacterCommand.Parameters.AddWithValue("@spellcraft", character.skills[43].value);
            addcharacterCommand.Parameters.AddWithValue("@spot", character.skills[44].value);
            addcharacterCommand.Parameters.AddWithValue("@survival", character.skills[45].value);
            addcharacterCommand.Parameters.AddWithValue("@swim", character.skills[46].value);
            addcharacterCommand.Parameters.AddWithValue("@tumble", character.skills[47].value);
            addcharacterCommand.Parameters.AddWithValue("@useMagicDevice", character.skills[48].value);
            addcharacterCommand.Parameters.AddWithValue("@useRope", character.skills[49].value);
            addcharacterCommand.Parameters.AddWithValue("@autohypnosis", character.skills[50].value);
            addcharacterCommand.Parameters.AddWithValue("@psionics", character.skills[51].value);
            addcharacterCommand.Parameters.AddWithValue("@psicraft", character.skills[52].value);
            addcharacterCommand.Parameters.AddWithValue("@usePsi", character.skills[53].value);



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
