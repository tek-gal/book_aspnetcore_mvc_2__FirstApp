using System.Collections.Generic;


namespace FirstApp.Models {

    public class Repository {

        private static List<GuestResponse> responses = new List<GuestResponse>();

        public static IEnumerable<GuestResponse> Responses {
            get {
                return responses;
            }
        }

        public static void AddResponse(GuestResponse guestResponse) {
            responses.Add(guestResponse);
        }

    }

}