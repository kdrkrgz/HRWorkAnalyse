/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { PhonecallService } from './phonecall.service';

describe('Service: Phonecall', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PhonecallService]
    });
  });

  it('should ...', inject([PhonecallService], (service: PhonecallService) => {
    expect(service).toBeTruthy();
  }));
});
