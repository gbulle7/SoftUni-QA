async function promiseRejectionAsync() {
   let promise = new Promise(function(resolve, reject) { 
      setTimeout(function() {
         reject("Error");
      }, 1000)
   })
   try{
      await promise;
   }
   catch(err){
      console.log(err);
   }
}


// async function promiseRejectionAsync() {
//    try {
//        await new Promise((_, reject) => setTimeout(() => reject(new Error("Oops!")), 1000));
//    } catch (error) {
//        console.error(error.message);
//    }
// }