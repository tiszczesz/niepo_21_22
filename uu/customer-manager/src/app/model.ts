export interface Customer {
  name: string;
  photoUrl: string;
  description: string;
  age: number;
  address: Address;
}

export interface Address {
  street: string;
  houseNumber: number;
  city: string;
}
