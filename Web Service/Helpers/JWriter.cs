using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Web_Service.Models;

namespace Web_Service.Helpers
{
    static public class JWriter<T>
    {
        static public string Write(in T collection, string current_data = null)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            try
            {
                using (Newtonsoft.Json.JsonWriter writer = new JsonTextWriter(sw))
                {
                    writer.Formatting = Formatting.Indented;

                    writer.WriteStartArray();

                    foreach (var item in (System.Collections.IList)collection)
                    {
                        writer.WriteStartObject();

                        writer.WritePropertyName("ShortName");
                        writer.WriteValue((item as MoscowEducationalInstitutionInfo).ShortName);

                        writer.WritePropertyName("FullName");
                        writer.WriteValue((item as MoscowEducationalInstitutionInfo).FullName);


                        writer.WritePropertyName("LicensingAndAccreditation");
                        writer.WriteStartArray();
                        foreach (var element in (item as MoscowEducationalInstitutionInfo).LicensingAndAccreditation)
                        {
                            writer.WriteStartObject();

                            writer.WritePropertyName("LicenseAvailability");
                            writer.WriteValue(element.LicenseAvailability);

                            writer.WritePropertyName("AccreditationAvailability");
                            writer.WriteValue(element.AccreditationAvailability);

                            writer.WriteEndObject();
                        }

                        writer.WriteEnd();


                        writer.WritePropertyName("InstitutionsAddresses");
                        writer.WriteStartArray();
                        foreach (var element in (item as MoscowEducationalInstitutionInfo).InstitutionsAddresses)
                        {
                            writer.WriteStartObject();

                            writer.WritePropertyName("AdmArea");
                            writer.WriteValue(element.AdmArea);

                            writer.WritePropertyName("District");
                            writer.WriteValue(element.District);

                            writer.WritePropertyName("Address");
                            writer.WriteValue(element.Address);

                            writer.WriteEndObject();
                        }

                        writer.WriteEnd();


                        writer.WritePropertyName("LegalOrganization");
                        writer.WriteValue((item as MoscowEducationalInstitutionInfo).LegalOrganization);

                        writer.WritePropertyName("Subordination");
                        writer.WriteValue((item as MoscowEducationalInstitutionInfo).Subordination);

                        writer.WritePropertyName("ChiefName");
                        writer.WriteValue((item as MoscowEducationalInstitutionInfo).ChiefName);

                        writer.WritePropertyName("LegalAddress");
                        writer.WriteValue((item as MoscowEducationalInstitutionInfo).LegalAddress);

                        writer.WritePropertyName("OrgType");
                        writer.WriteValue((item as MoscowEducationalInstitutionInfo).OrgType);

                        writer.WritePropertyName("WebSite");
                        writer.WriteValue((item as MoscowEducationalInstitutionInfo).WebSite);

                        writer.WriteEndObject();
                    }

                    writer.WriteEnd();

                    if (current_data != "\r\n" && !string.IsNullOrEmpty(current_data))
                    {
                        JArray current_doc = JArray.Parse(current_data);

                        JArray new_data = JArray.Parse(sb.ToString());
                        var child_new_data = new_data.Children();

                        current_doc.Add(child_new_data);

                        return current_doc.ToString();

                    }

                    return sb.ToString();
                }
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

        }
    }
}