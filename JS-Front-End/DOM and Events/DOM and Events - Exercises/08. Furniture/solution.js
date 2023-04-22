function solve() {
  const btns = [...document.querySelectorAll('button')]
  let table = document.querySelector('tbody')
  btns[0].addEventListener('click', generate)
  btns[1].addEventListener('click', buy)

  function generate() {
      let input = JSON.parse(document.querySelector('textarea').value)

      function img(data) {
          let newRow = document.createElement('td')
          const img = document.createElement('img')
          img.src = data
          newRow.appendChild(img)
          return newRow
      }

      function p(data) {
          let newRow = document.createElement('td')
          const p = document.createElement('p')
          p.textContent = data
          newRow.appendChild(p)
          return newRow
      }

      for (x = 0; x < input.length; x++) {
          let newRow = document.createElement('tr')
          newRow.appendChild(img(input[x]['img']))
          newRow.appendChild(p(input[x]['name']))
          newRow.appendChild(p(input[x]['price']))
          newRow.appendChild(p(input[x]['decFactor']))
          
          let td = document.createElement('td')
          let checkbox = document.createElement('input')
          checkbox.setAttribute("type", "checkbox")
          td.appendChild(checkbox)
          newRow.appendChild(td)
          table.appendChild(newRow)
      }
  }

  function buy() {
      let rows = table.querySelectorAll('tr')

      let avrDeco = 0
      let totalSum = 0
      let names = []
      for (x = 0; x < rows.length; x++) {
          item = rows[x]
          if (item.children[4].children[0].checked) {
              names.push(item.children[1].textContent.trim())
              totalSum += parseFloat(item.children[2].textContent)
              avrDeco += parseFloat(item.children[3].textContent)
          }
      }
      if (names.length > 0) {
          document.querySelectorAll('textarea')[1].value = `Bought furniture: ${names.join(', ')}\nTotal price: ${totalSum.toFixed(2)}\nAverage decoration factor: ${avrDeco / names.length}`
      }
  }
}