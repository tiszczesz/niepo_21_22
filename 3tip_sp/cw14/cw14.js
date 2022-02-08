class Contact {
  constructor(firstname, lastname, phone) {
    this.firstname = firstname;
    this.lastname = lastname;
    this.phone = phone;
  }
  generRow() {
    return `
            <tr>
            <td>${this.firstname}</td>
            <td>${this.lastname}</td>
            <td>${this.phone}</td>
            </tr>
        `;
  }
}
