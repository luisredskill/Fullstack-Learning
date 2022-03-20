function verificar(){
   var data = new Date()
   var ano = data.getFullYear()
   var fano = document.getElementById("txtano")
   window.alert(fano)
   var res = document.querySelector("div#res")
   if(fano.value.length == 0 || fano.value > ano){
       window.alert("[ERRO] verifique o ano novamente")
   } else{
      var fsex = document.getElementsByName("radsex")
      var idade = ano - fano.value
      var genero = ""
      var img = document.createElement('img')
      img.setAttribute('id', 'foto')
      if(fsex[0].checked) {
          genero = "Homem"
          if (idade < 10) {
            img.setAttribute("src", "criancahomem.png")
          } else if (idade < 20) {
            img.setAttribute("src", "jovemhomem.png")
          } else if (idade < 50) {
            img.setAttribute("src", "adultohomem.png")
         } else {
            img.setAttribute("src", "idosohomem.png")
         }
          
    } else {
       genero = "Mulher"
       if (idade < 10) {
         img.setAttribute("src", "criancamulher.png")
       } else if (idade < 20) {
         img.setAttribute("src", "jovemmulher.png")
       } else if (idade < 50) {
         img.setAttribute("src", "adultomulher.png")
      } else {
         img.setAttribute("src", "idosomulher.png")
      }
       
    }
      
      res.style.textAlign = 'center'
      res.innerHTML = `Detectamos ${genero} com ${idade} anos.`
      res.appendChild(img)
      
   }
}