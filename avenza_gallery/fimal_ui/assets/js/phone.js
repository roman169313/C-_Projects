const phoneInputField = document.querySelector("#share-prop-num");
const info = document.querySelector(".alert-info");

const phoneInput = window.intlTelInput(phoneInputField, {
    preferredCountries: ["pk","ae", "us", "de", "za"],
    utilsScript:
      "https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/17.0.8/js/utils.js",
  });
function process(event) {
 event.preventDefault();

 const phoneNumber = phoneInput.getNumber();
// send phoneNumber and property
}

function getIp(callback) {
    fetch('https://ipinfo.io/json?token=<your token>', { headers: { 'Accept': 'application/json' }})
      .then((resp) => resp.json())
      .catch(() => {
        return {
          country: 'us',
        };
      })
      .then((resp) => callback(resp.country));
   }