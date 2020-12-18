using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeRepoTwo.Models;

namespace YoutubeRepoTwo.Services
{
    public class FirebaseHelper
    {
        public async Task<List<PersonModel>> GetAllPersons()
        {

            return (await firebase
              .Child("Persons")
              .OnceAsync<PersonModel>()).Select(item => new PersonModel
              {
                  NameField = item.Object.NameField,
                  PersonId = item.Object.PersonId,
                  AgeField = item.Object.AgeField
              }).ToList();
        }

        /*
        public async Task AddPerson(string name, int age)
        {
            await firebase
              .Child("Persons")
              .PostAsync(new PersonModel() { PersonId = Guid.NewGuid(), NameField = name, AgeField = age});
        }
        */

        public async Task AddPerson(PersonModel _personModel)
        {
            await firebase
            .Child("Persons")
            .PostAsync(new PersonModel()
            {
                PersonId = Guid.NewGuid(),
                NameField = _personModel.NameField,
                AgeField = _personModel.AgeField,
            });
        }


        public async Task UpdatePerson(PersonModel _personModel)
        {
            var toUpdatePerson = (await firebase
              .Child("Persons")
              .OnceAsync<PersonModel>()).Where(a => a.Object.PersonId == _personModel.PersonId).FirstOrDefault();

            await firebase
              .Child("Persons")
              .Child(toUpdatePerson.Key)
              .PutAsync(new PersonModel() { PersonId = _personModel.PersonId, NameField = _personModel.NameField, AgeField = _personModel.AgeField});
        }

        public async Task DeletePerson(Guid personId)
        {
            var toDeletePerson = (await firebase
              .Child("Persons")
              .OnceAsync<PersonModel>()).Where(a => a.Object.PersonId == personId).FirstOrDefault();
            await firebase.Child("Persons").Child(toDeletePerson.Key).DeleteAsync();

        }

        /*
        public async Task<PersonModel> GetPerson(int personId)
        {
            var allPersons = await GetAllPersons();
            await firebase
              .Child("Persons")
              .OnceAsync<PersonModel>();
            return allPersons.Where(a => a.PersonId == personId).FirstOrDefault();
        }



        public async Task UpdatePerson(int personId, string name)
        {
            var toUpdatePerson = (await firebase
              .Child("Persons")
              .OnceAsync<PersonModel>()).Where(a => a.Object.PersonId == personId).FirstOrDefault();

            await firebase
              .Child("Persons")
              .Child(toUpdatePerson.Key)
              .PutAsync(new PersonModel() { PersonId = personId, NameField = name });
        }

        public async Task DeletePerson(int personId)
        {
            var toDeletePerson = (await firebase
              .Child("Persons")
              .OnceAsync<PersonModel>()).Where(a => a.Object.PersonId == personId).FirstOrDefault();
            await firebase.Child("Persons").Child(toDeletePerson.Key).DeleteAsync();

        }
        */
        FirebaseClient firebase;
        public FirebaseHelper()
        {
            firebase = new FirebaseClient("https://project-3cb9f-default-rtdb.firebaseio.com/");
        }
    }
}
