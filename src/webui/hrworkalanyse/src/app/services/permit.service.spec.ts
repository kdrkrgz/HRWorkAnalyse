/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { PermitService } from './permit.service';

describe('Service: Permit', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PermitService]
    });
  });

  it('should ...', inject([PermitService], (service: PermitService) => {
    expect(service).toBeTruthy();
  }));
});
